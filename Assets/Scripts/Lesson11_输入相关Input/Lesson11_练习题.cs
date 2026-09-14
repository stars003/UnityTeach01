using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson11_练习题 : MonoBehaviour
{
    private float h; //左右转向
    private float v; //前进后退
    private float m; //炮台转向
    private float g; //炮管摆动
    private float cx; //摄像机水平转向
    private float cy; //摄像机垂直转向


    private Transform 炮台;
    private Transform 炮管架;
    private Transform 摄像机;
    public float 速率; //速度系数
    public float 炮管最大仰角;
    public float 炮管最低压角;

    //把这道题的代码保留好, 之后的题会用到
    //

    // Start is called before the first frame update
    void Start()
    {
        速率 = 10;
        炮管最大仰角 = 7;
        炮管最低压角 = 4;

        炮台 = this.transform.Find("炮台");
        炮管架 = 炮台.Find("炮管架");
        摄像机 = this.transform.Find("Camera");


    }

    // Update is called once per frame
    void Update()
    {

        #region 练习题一
        //1.使用之前的坦克预设体,用WASD键控制坦克的前景后退,左右转向

        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.S))
        {
            v = (float)Math.Round( Input.GetAxis("Vertical"),2) * 速率 * 3;
            if (v != 0)
            {
                this.transform.Translate(Vector3.forward * v * Time.deltaTime, Space.Self);
            }
        }
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D))
        {
            h = (float)Math.Round(Input.GetAxis("Horizontal"),2) * 速率 * 10;
            if (h != 0)
            {
                this.transform.Rotate(Vector3.up, h * Time.deltaTime); ;
            }
        }

        #endregion

        #region 练习题二
        //2.在上一题的基础上,鼠标左右移动控制炮台的转向
        if (Input.GetMouseButton(2))
        {
            m = (float)Math.Round(Input.GetAxis("Mouse X"), 2) * 速率 * 20;
            if (m != 0)
            {
                炮台.Rotate(Vector3.up, m * Time.deltaTime); ;
            }
        }

        #endregion

        #region 练习题 Lesson12 - 1
        //1.在输入习题的基础上,鼠标滚轮控制控制炮管的抬起放下
        g = (float)Math.Round(Input.mouseScrollDelta.y, 2) * 10 * 速率;
        if (g != 0)
        {
            炮管架.Rotate(Vector3.right * g * Time.deltaTime); ;
        }
        if (炮管架.localEulerAngles.x > 炮管最低压角 && 炮管架.localEulerAngles.x < (360 - 炮管最大仰角))
        {
            炮管架.localEulerAngles = g > 0 ? new Vector3(4, 0, 0) : new Vector3((360 - 炮管最大仰角), 0, 0);
        }
        #endregion

        #region 练习题 Lesson12 - 2
        //2.在上一题的基础上,加入长按鼠标右键移动鼠标可以让摄像机围着坦 克旋转, 改变观察坦克的视角
        if (Input.GetMouseButton(1))
        {
            摄像机.LookAt(this.transform);

            cx = (float)Math.Round(Input.GetAxis("Mouse X"), 2) * 速率 * 40;
            cy = (float)Math.Round(Input.GetAxis("Mouse Y"), 2) * 速率 * -20;

            if (cx != 0)
            {
                摄像机.RotateAround(this.transform.position, this.transform.up, cx * Time.deltaTime);
            }
            if (cy != 0)
            {
                摄像机.RotateAround(this.transform.position, this.transform.right, cy * Time.deltaTime);
            }
            //else if(摄像机.position.x > 0)
            //{
            //     && 摄像机.position.x > 0 && 摄像机.position.x < 180
            //}
        }
        #endregion
    }
}
