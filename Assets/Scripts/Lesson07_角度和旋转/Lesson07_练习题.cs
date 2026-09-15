using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class Lesson07_练习题 : MonoBehaviour
{
    public float 展台转速 = 10;
    public float 炮塔转速 = 10;
    public float 炮管摆速 = 10;

    public int 炮塔转角 = 45;
    //public int 炮管转角 = 10;

    public Transform 炮塔;
    public Transform 炮管架;

    public Transform 太阳;
    public Transform 地球;
    public Transform 月亮;
    public Transform 北极星;

    //public Transform 北极星;

    // Start is called before the first frame update
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {
        #region 练习题一
        //1.使用你之前创建的坦克预设体,在坦克下面加一个底座(用自带几何
        //体即可)让其可以原地旋转,类似一个展览台
        
        //展台旋转
        this.transform.Rotate(Vector3.up, 展台转速 * Time.deltaTime, Space.Self);

        #endregion

        #region 练习题二
        //2.在第一题的基础上,让坦克的炮台可以自动左右来回旋转,炮管可以
        //自动上下抬起

        //炮塔旋转
        炮塔.Rotate(Vector3.up, 炮塔转速 * Time.deltaTime, Space.Self);

        //炮管摆动
        炮管架.Rotate(Vector3.right, 炮管摆速 * Time.deltaTime, Space.Self);

        if (!(炮塔.localEulerAngles.y >= (360 - 炮塔转角) && 炮塔.localEulerAngles.y < 360) 
            && 炮塔.localEulerAngles.y >= 炮塔转角 && 炮塔转速 > 0)
            炮塔转速 = -炮塔转速;
        else if (!(炮塔.localEulerAngles.y <= 炮塔转角 && 炮塔.localEulerAngles.y >= 0) 
            && 炮塔.localEulerAngles.y <= (360 - 炮塔转角) && 炮塔转速 < 0)
            炮塔转速 = -炮塔转速;

        if (!(炮管架.localEulerAngles.x >= 345 && 炮管架.localEulerAngles.x < 360) 
            && 炮管架.localEulerAngles.x >= 4 && 炮管摆速 > 0)
            炮管摆速 = -炮管摆速;
        else if (!(炮管架.localEulerAngles.x <= 4 && 炮管架.localEulerAngles.x >= 0) 
            && 炮管架.localEulerAngles.x <= 345 && 炮管摆速 < 0)
            炮管摆速 = -炮管摆速;

        #endregion

        #region 练习题三
        //3.请用3个球体, 模拟太阳、地球、月亮之间的旋转移动

        //太阳自转
        太阳.Rotate(Vector3.up, -0.55f * Time.deltaTime, Space.World);

        //地球自转
        //地球.Rotate(Vector3.up, -15 * Time.deltaTime, Space.Self);

        //月亮自转
        //月亮.Rotate(Vector3.up, -0.5f * Time.deltaTime, Space.Self);
        //月亮.LookAt(地球);

        //北极星定位
        北极星.LookAt(地球);
        北极星.RotateAround(太阳.position, Vector3.up, (-7.3f * Time.deltaTime));


        //地球绕着太阳转
        //地球.RotateAround(太阳.position, Vector3.up, (-7.3f * Time.deltaTime));

        //月亮绕着地球转
        //月亮.RotateAround(地球.position, Vector3.up, (-4.17f * Time.deltaTime));



        #endregion



    }
}
