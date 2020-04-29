using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class Monster : ICloneable
{
    /* 用原型实例制定创建对象的种类
     * 通过拷贝这个原型来创建新的对象  */

    private string name;
    private float speed;
    private float ATK;
    private Weapon weapon;

    public Monster(string name)
    {
        this.name = name;
        weapon = new Weapon();
    }
    
    public void setMonsterInfo(float speed, float ATK)
    {
        this.speed = speed;
        this.ATK = ATK;
    }

    public void Attack()
    {
        Debug.Log(name + " Attack!");
    }

    public object Clone()
    {
        /* 创建当前对象的浅表副本，将非静态字段复制
         * 如果字段是值类型，逐位复制
         * 如果字段是引用类型，复制引用（不复制引用的对象）*/ 
        return (Monster)this.MemberwiseClone();
    }
}