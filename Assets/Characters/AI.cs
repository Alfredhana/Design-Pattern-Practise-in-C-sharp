using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ConcreteStatus;

public class AI : Character
{
    private Status status;
    public IdleState idleState;
    public ChaseState chaseState;
    public BackState backState;

    private GameObject player;
    public GameObject Player { get { return player; } set { player = value; } }

    public float viewRadius;
    public float viewAngleStep;

    public float maxChasingDistance;
    public float maxHomeDistance;

    private Vector3 basePosition;
    public Vector3 BasePosition { get { return basePosition; } }
    private Quaternion baseDirection;
    public Quaternion BaseDirection { get { return baseDirection; } }
    public Vector3 currentPosition { get { return transform.position; } }
    public bool hasAttacker;
    Rigidbody rigidbody;

    public AI(string name) : base(name) { }

    public void Start()
    {
        basePosition = transform.position;
        baseDirection = transform.rotation;
        rigidbody = GetComponent<Rigidbody>();
        idleState = new IdleState(this);
        status = idleState;
        chaseState = new ChaseState(this);
        backState = new BackState(this);
    }

    public void Update()
    {
        DrawFieldOfView();
    }

    void DrawFieldOfView()
    {
        // 获得最左边那条射线的向量，相对正前方，角度是-45
        Vector3 forward_left = Quaternion.Euler(0, -45, 0) * transform.forward * viewRadius;
        // 依次处理每一条射线
        for (int i = 0; i <= viewAngleStep; i++)
        {
            // 每条射线都在forward_left的基础上偏转一点，最后一个正好偏转90度到视线最右侧
            Vector3 v = Quaternion.Euler(0, (90.0f / viewAngleStep) * i, 0) * forward_left; 
            // 创建射线
            Ray ray = new Ray(transform.position, v);
            RaycastHit hitt = new RaycastHit();
            // 射线只与两种层碰撞，注意名字和你添加的layer一致，其他层忽略
            int mask = LayerMask.GetMask("Obstacle", "Player");
            Physics.Raycast(ray, out hitt, viewRadius, mask);

            // Player位置加v，就是射线终点pos
            Vector3 pos = transform.position + v;
            if (hitt.transform != null)
            {
                // 如果碰撞到什么东西，射线终点就变为碰撞的点了
                pos = hitt.point;
            }
            // 从玩家位置到pos画线段，只会在编辑器里看到
            Debug.DrawLine(transform.position, pos, Color.red);

            // 如果真的碰撞到敌人，进一步处理
            if (hitt.transform != null && hitt.transform.gameObject.layer == LayerMask.NameToLayer("Player"))
            {
                player = hitt.collider.gameObject;
                hasAttacker = true;
            }
        }


    }

    public void InitialRotation()
    {
        if (BaseDirection != transform.rotation)
            transform.rotation = Quaternion.RotateTowards(transform.rotation, BaseDirection, turnSpeed);
    }

    public void MoveToPosition(Vector3 pos)
    {
        Vector3 v = pos - transform.position;
        v.y = 0;
        transform.position += v.normalized * speed * Time.deltaTime;
    }

    public void MoveToPosition(string str)
    {
        if (str == "Player")
        {
            Vector3 v = player.transform.position - transform.position;
            v.y = 0;
            transform.position += v.normalized * speed * Time.deltaTime;
        }
    }

    public bool IsFacing(string str)
    {
        Vector3 pos = Vector3.zero;
        if (str == "Player")
        {
            if (player == null)
            {
                return false;
            }
            pos = player.transform.position;
        }
        else if (str == "Home")
        {
            pos = BasePosition;
        }
        Vector3 v1 = pos - transform.position;
        v1.y = 0;
        // Vector3.Angle获得的是一个0~180度的角度，和参数两个向量顺序无关
        if (Vector3.Angle(transform.forward, v1) < 1)
        {
            return true;
        }
        return false;
    }

    // 转向入侵者方向，每次只转一点，速度受turnSpeed控制
    public void RotateTo(string str)
    {
        Vector3 pos = Vector3.zero;
        if (str == "Player")
        {
            if (player == null)
            {
                return;
            }
            pos = player.transform.position;
        }
        else if (str == "Home")
        {
            pos = BasePosition;
        }
        Vector3 v1 = player.transform.position - transform.position;
        v1.y = 0;
        // 结合叉积和Rotate函数进行旋转，很简洁很好用，建议掌握
        // 使用Mathf.Min(turnSpeed, Mathf.Abs(angle))是为了严谨，避免旋转过度导致的抖动
        Vector3 cross = Vector3.Cross(transform.forward, v1);
        float angle = Vector3.Angle(transform.forward, v1);
        transform.Rotate(cross, Mathf.Min(turnSpeed, Mathf.Abs(angle)));
    }

    public bool IsInPosition(Vector3 pos)
    {
        Vector3 v = pos - transform.position;
        v.y = 0;
        return v.magnitude < 0.5f;
    }

    public void ChangeStatus(Status status)
    {
        this.status = status;
    }

    public void ResetAttacker()
    {
        hasAttacker = false;
        player = null;
    }

    public void Request()
    {
        status.CheckRotation();
        status.CheckAttacker();
        status.CheckPosition();
        status.MovePosition();
    }
}