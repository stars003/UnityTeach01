using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson12_练习题 : MonoBehaviour
{
    private float g;
    public float 炮管最大仰角;
    public float 炮管最低压角;
    private Transform 炮管架;
    // Start is called before the first frame update
    void Start()
    {
        炮管架 = this.transform.Find("炮台").Find("炮管架");
        炮管最大仰角 = 7;
        炮管最低压角 = 4;
    }

    // Update is called once per frame
    void Update()
    {
        #region 练习题一
        //1.在输入习题的基础上,鼠标滚轮控制控制炮管的抬起放下
        g = (float)Math.Round(Input.mouseScrollDelta.y,2) * 100;
        if (g != 0 )
        {
            炮管架.Rotate(Vector3.right, g * Time.deltaTime, Space.Self); ;
        }
        if (炮管架.localEulerAngles.x > 炮管最低压角 && 炮管架.localEulerAngles.x < (360 - 炮管最大仰角))
        {
            炮管架.localEulerAngles = g > 0 ?  new Vector3(4, 0, 0) : new Vector3((360 - 炮管最大仰角), 0, 0);
        }


        #endregion

        #region 练习题二
        //2.在上一题的基础上,加入长按鼠标右键移动鼠标可以让摄像机围着坦 克旋转, 改变观察坦克的视角
        if (Input.GetMouseButton(1))
        {

        }

        #endregion

    }
}
