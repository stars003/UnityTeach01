using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson01 : MonoBehaviour
{
    #region 生命周期函数

    #endregion
    //类似于C#中的构造函数，Unity中不建议使用构造函数来初始化对象，而是使用Awake()方法来进行初始化操作。
    protected virtual void Awake()
    {
        //在Unity中打印信息的两种方式
        //1.没有继承MonoBehaviour，在Unity中打印日志
        //Debug.Log("Debug");
        //Debug.LogWarning("警告！！！！！");
        //Debug.LogError("出错了！！！");
        //2.继承了MonoBehaviour，在Unity中打印信息
        print("Awake");

    }

    //对于我们来说，想要在游戏对象被启用时进行一些逻辑处理，就可以使用OnEnable()方法。这个方法会在游戏对象被启用时自动调用。
    void OnEnable()
    {
        print("OnEnable");
    }

    void Start()
    {
        print("Start");
    }

    //它主要是用于 进行物理更新
    //它是每一帧的执行的 但是这里的帧和游戏帧有所不同
    //它的执行频率是固定的，默认情况下是每秒执行50次，可以在 Edit -> Project Settings -> Time 中修改Fixed Timestep的值来改变它的执行频率。
    private void FixedUpdate()
    {
        print("FixedUpdate");
    }
    //主要用于处理游戏逻辑的更新，比如玩家输入、AI行为等。它会在每一帧调用一次，调用的频率取决于游戏的帧率。
    void Update()
    {
        print("Update");
    }

    //一般这个更新是用来处理 摄像机位置更新相关内容的
    //Update和LateUpdate之间 Unity进行了优化处理，处理我们动画的更新。
    //Update是在每一帧的开始阶段调用，而LateUpdate是在每一帧的结束阶段调用。也就是说，Update会在所有游戏对象的Update方法执行完之后，再执行LateUpdate方法。
    void LateUpdate()
    {
        print("LateUpdate");
    }
    //如果我们希望在一个对象失活时做一些处理，就可以在该函数中写逻辑
    void OnDisable()
    {
        print("OnDisable");
    }
    void OnDestroy()
    {
        print("OnDestroy");
    }

}
