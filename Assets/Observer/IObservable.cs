using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IObservable
{
    /* 定义一对多的依赖关系
     * 让多个观察者对象同时监听一个主题对象
     * 对象状态改变时通知所有观察者对象 */

    void Attach(Observer observer);

    void DeTach(Observer observer);

    protected override void Nofity();

    string SecretaryAction
    {
        get;
        set;
    }
}
