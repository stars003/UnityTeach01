using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson05 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        #region 知识点一 时间缩放比例
        //时间停止
        //Time.timeScale = 0;
        //恢复正常
        //Time.timeScale = 1;
        //2倍速
        //Time.timeScale = 2;
        #endregion

        #region 知识点二 帧间隔时间
        //帧间隔时间 主要是用来计算位移
        //路程=时间*速度
        //根据需求 选择参与计算间隔时间
        //如果希望 游戏暂停时就不动的 那就使用deltaTime
        //如果希望 不受暂停影响 unScaledDeltaTime

        //帧间隔时间：最近的一帧 用了多长时间（单位：秒）
        //受Scale影响
        //print("帧间隔时间：" + Time.deltaTime);
        //不受Scale影响的帧间隔时间
        //print("不受Scaley影响的帧间隔时间：" + Time.unscaledDeltaTime);
        #endregion

        #region 知识点三 游戏开始到现在的时间
        //它主要用来计时 单机游戏中计时
        //受Scale影响
        //print("游戏开始到现在的时间：" + Time.time);
        //不受Scale影响
        //print("不受Scaley影响的游戏开始到现在的时间：" + Time.unscaledTime);

        #endregion


        #region 知识点五 帧数
        //从开始到现在游戏跑了多少帧（多少次循环）
        print(Time.frameCount);
        #endregion

    }

    private void FixedUpdate()
    {
        #region 知识点四 物理帧间隔时间 FixedUpdate
        //受Scale影响
        //print("帧间隔时间：" + Time.fixedDeltaTime);
        //不受Scale影响
        //print("不受Scaley影响的帧间隔时间：" + Time.fixedUnscaledDeltaTime);

        #endregion
    }

    //总结
    //Time相关的内容
    //最常用的 就是我们的、
    //1.帧间隔时间 就用计算位移相关内容
    //2.时间缩放比例 用来暂停 或者倍速等等
    //3.帧数(帧同步)
}
