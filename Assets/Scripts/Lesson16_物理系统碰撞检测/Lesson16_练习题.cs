using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson16_练习题 : MonoBehaviour
{

    #region Lesson16 - 练习题二
    //2.在上一题的基础上,加入子弹触碰到地面会自动消失的功能


    #endregion

    #region Lesson16 - 练习题三
<<<<<<< Updated upstream
    //3.在上一题的基础上,在场景加入一些立方体,每个立方体被子弹打3 下就会消失
=======
    //3.在上一题的基础上,在场景加入一些立方体,每个立方体被子弹打 3 下就会消失
>>>>>>> Stashed changes


    #endregion

    private float h; //左右转向
    private float v; //前进后退
    private float m; //炮台转向
    private float g; //炮管摆动
    private float cx; //摄像机水平转向
    private float cy; //摄像机垂直转向
<<<<<<< Updated upstream


=======
>>>>>>> Stashed changes
    private Transform 炮台;
    private Transform 炮管架;
    private Transform 摄像机;
    public float 速率; //速度系数
    public float 炮管最大仰角;
    public float 炮管最低压角;
<<<<<<< Updated upstream
    public GameObject 炮弹;

    private GameObject 炮弹1;
=======
    public GameObject 炮弹预设体;
    public Transform 弹药初始位置;
>>>>>>> Stashed changes

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
<<<<<<< Updated upstream


=======
>>>>>>> Stashed changes
    }

    // Update is called once per frame
    void Update()
    {

        #region Lesson11 - 练习题一
        //1.使用之前的坦克预设体,用WASD键控制坦克的前景后退,左右转向

        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.S))
        {
            v = (float)Math.Round(Input.GetAxis("Vertical"), 2) * 速率;
            if (v != 0)
            {
                this.transform.Translate(Vector3.forward * v * Time.deltaTime, Space.Self);
            }
        }
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D))
        {
            h = (float)Math.Round(Input.GetAxis("Horizontal"), 2) * 速率 * 10;
            if (h != 0)
            {
                this.transform.Rotate(Vector3.up, h * Time.deltaTime); ;
            }
        }

        #endregion

        #region Lesson11 - 练习题二
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

        #region Lesson12 - 练习题一
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

        #region Lesson12 - 练习题二
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

        #region Lesson16 - 练习题一
        //1.在之前Input和Screen中的练习题基础上
        //加入一个点击鼠标左键可以发射一颗子弹飞出的功能
        if (Input.GetMouseButtonDown(0))
        {
<<<<<<< Updated upstream
            炮弹1 = GameObject.Instantiate(炮弹);
            炮弹 pd = 炮弹1.AddComponent<炮弹>();

            炮弹1.transform.position = 炮管架.transform.TransformPoint(new Vector3(0, 0, 5.5f));
            //发射子弹
            Rigidbody rb = 炮弹1.AddComponent<Rigidbody>();
            rb.useGravity = false;
            rb.AddForce(炮管架.forward * 速率 * 150);
            //炮弹1.transform.Translate(炮弹1.transform.forward * 速率 * Time.deltaTime, Space.World);        
        }


=======
            //炮弹1 = GameObject.Instantiate(炮弹预设体);
            //实例化一个子弹对象
            GameObject obj = GameObject.Instantiate(炮弹预设体);
            //设置对象的位置
            obj.transform.position = 弹药初始位置.position;
            //设置对象的旋转角度
            obj.transform.eulerAngles = 弹药初始位置.eulerAngles;
            //给炮弹添加脚本
            //炮弹 pd = obj.AddComponent<炮弹>();

            //炮弹 pd = 炮弹1.AddComponent<炮弹>();
            //炮弹1.transform.position = 炮管架.transform.TransformPoint(new Vector3(0, 0, 5.5f));
            //发射子弹
            //Rigidbody rb = 炮弹1.AddComponent<Rigidbody>();
            //rb.useGravity = false;
            //rb.AddForce(炮管架.forward * 速率 * 150);
            //炮弹1.transform.Translate(炮弹1.transform.forward * 速率 * Time.deltaTime, Space.World);
        }
>>>>>>> Stashed changes
        #endregion

    }
}
