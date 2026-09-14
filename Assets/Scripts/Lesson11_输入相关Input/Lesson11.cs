using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson11 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        #region 注意：输入相关内容肯定是写在Update中的


        #endregion

        #region 知识点一 鼠标在屏幕位置
        //屏幕坐标的原点 是在 屏幕的左下角  往右是x轴正方向 往上时Y轴正方向
        //返回值时Vector3 但是只有 x和y有值 z一直是0 是因为屏幕本来就是2D的 不存在Z轴
        //print(Input.mousePosition);

        #endregion

        #region 知识点二 检测鼠标输入
        //鼠标按下相关检测 对于我们来说
        //比如：1.可以做 发射子弹
        //      2.可以控制摄像机 转动

        //鼠标按下的一瞬间 进入
        //0左键 1右键 2中键
        //只有按下的这一瞬间 进入一次
        if (Input.GetMouseButtonDown(0))
        {
            print("鼠标左键在" + Input.mousePosition + "位置按下了。");
        }

        //鼠标抬起的一瞬间 进入
        if (Input.GetMouseButtonUp(0))
        {
            print("鼠标左个键在" + Input.mousePosition + "位置抬起了。");
        }

        //鼠标长按按下抬起都会进入
        //就是 当按住按键不放时 会一直进入 这个判断
        if (Input.GetMouseButton(1))
        {
            print("鼠标右键在" + Input.mousePosition + "位置按下了。");
        }

        //中键滚动
        //返回值的 y -1往下滚 0没有滚 1往上滚 
        //它的返回值 是Vector的值 我们鼠标中键滚动 会改变其中的Y值
        //print(Input.mouseScrollDelta);
        #endregion

        #region 知识点三 检测键盘输入
        //键盘按下
        if (Input.GetKeyDown(KeyCode.W))
        {
            print("W键按下");
        }

        //传入字符串的重载
        //这里传入的 字符串 不能是大写的 不能会报错
        //只能传入小写字符串
        if (Input.GetKeyDown("q"))
        {
            print("Q键按下");
        }

        //键盘抬起
        if (Input.GetKeyUp(KeyCode.W))
        {
            print("W键抬起");
        }

        //键盘长按
        if (Input.GetKey(KeyCode.W))
        {
            print("W键长按");
        }
        #endregion

        #region 知识点四 检测默认轴输入
        //我们学习鼠标 键盘输入 主要是来用来
        //控制玩家 比如 旋转 位移等等
        //所以Unity提供了 更方便的方法 来帮助我们控制 对象的 位移和旋转

        //键盘AD按下时 返回 -1到1之间的变换
        //相当于 得到的这个值 就是我们的 左右方向 我们可以通过它来控制 对象左右移动 或者左右旋转
        //float h = Input.GetAxis("Horizontal");
        //print(h);

        ////键盘sw按下时 返回 -1到1之间的变换
        //print(Input.GetAxis("Vertical"));

        //// 鼠标横向移动时 - 1 到1左右
        //print(Input.GetAxis("Mouse X"));

        ////鼠标竖向移动时 -1 到1 下上
        //print(Input.GetAxis("Mouse Y"));

        //GetAxisRaw方法 和 GetAxis使用方式相同
        //只不过 它的返回值 只会是 -1 0 1 不会有中间值
        //print(Input.GetAxisRaw("Horizontal"));

        #endregion

        #region 其它
        //是否有任意键或鼠标长按
        if (Input.anyKey)
        {
            print("有一个键长按");
        }
        //是否有任意键或鼠标按下
        if (Input.anyKeyDown)
        {
            print("有一个键按下");
            //这一帧的键盘输入
            print(Input.inputString);
        }

        //手柄输入相关
        //得到连接的手柄的所有按钮名字
        string[] strs = Input.GetJoystickNames();

        //某一个手柄键按下
        if (Input.GetButtonDown("Jump"))
        {
            
        }

        //某一个手柄键抬起
        if (Input.GetButtonUp("Jump"))
        {

        }

        //某一个手柄键长按
        if (Input.GetButton("Jump"))
        {

        }

        //移动设备触摸相关
        if(Input.touchCount > 0)
        {
            Touch t1 = Input.touches[0];
            //位置
            print(t1.position);
            //相对上次位置的变化
            print(t1.deltaPosition);
        }
        
        //是否启动多点触控
        Input.multiTouchEnabled = false;

        //陀螺仪（重力感应）
        //是否开启陀螺仪 必须开启 才能正常使用
        Input.gyro.enabled = true;

        //重力加速度向量
        print(Input.gyro.gravity);

        //旋转速度
        print(Input.gyro.rotationRate);

        //陀螺仪 当前的旋转四元数
        //比如 用这个角度信息 来控制 场景上的一个3D物体受到重力影响 
        //手机怎么动 它怎么动
        print(Input.gyro.attitude);

        #endregion
    }

    //总结
    //总结
    //Input类 提供大部分和输入相关的内容 
    //鼠标、键盘、触屏、手柄、重力感应 
    //对于我们目前来说 
    //鼠标、键盘 是必须掌握的核心知识
    //今天必须记住 鼠标键盘输入相关的API
    //GetAxis
}
