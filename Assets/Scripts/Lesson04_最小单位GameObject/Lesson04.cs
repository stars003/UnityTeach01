using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson04 : MonoBehaviour
{
    //准备用来克隆的对象
    //1.直接是场景上的某个对象
    //2.可以是一个预设体对象
    public GameObject myobj;

    public GameObject myobj2;

    // Start is called before the first frame update
    void Start()
    {
        #region 知识点一 GameObject中的成员变量
        //名字
        print(this.gameObject.name);
        this.gameObject.name = "Lesson04改名";
        print(this.gameObject.name);
        //是否激活
        print(this.gameObject.activeSelf);
        //是否是静态
        print(this.gameObject.isStatic);
        //层级
        print(this.gameObject.layer);
        //标签
        print(this.gameObject.tag);
        //transform
        //this.transform 上一节课讲解的 通过Mono去得到的依附对象的GameObject的位置信息
        //他们得到的信息是一样的 都是依附的GameObject的位置信息
        print(this.gameObject.transform.position);
        #endregion

        #region 知识点二 GameObject中的静态方法
        //创建自带几何体
        //只要得到了一个GameObject对象 我就可以得到它身上挂载的任何脚本信息
        //通过obj.GetComponent来得到

        GameObject obj = GameObject.CreatePrimitive(PrimitiveType.Cube);
        obj.name = "我创建的立方体";

        //查找对象相关的知识
        //1、无法找到失活的对象
        //只能找到激活的对象
        //2、如果场景中 存在多个满足条件的对象
        //   我们是无法准确确定找到的是谁

        //1、查找单个对象
        //通过对象名查找
        //这个查找效率比较低下 因为他会在场景中的所有对象去查找
        GameObject obj2 = GameObject.Find("唐老师");
        if ( obj2 != null)
        {
            print(obj2.name);
        }
        else
        {
            print("没有找到对应对象");
        }
        //通过tag来查找对象
        //和下面功能一样GameObject.FindGameObjectWithTag();
        GameObject obj3 =  GameObject.FindWithTag("Player");
        if (obj3 != null)
        {
            print("根据tag找的对象" + obj3.name);
        }
        else
        {
            print("根据tag没有找到对应对象");
        }
        //得到某一个单个对象 目前有2种方式了
        //1.是public从外部面板拖 进行关联
        //2.通过API去找


        //2、查找多个对象
        //找多个对象的API 只能是通过tag去找多个 通过名字 是没有找多个的方法的

        //通过tag找到多个对象
        //只能找激活的对象
        GameObject[] objs = GameObject.FindGameObjectsWithTag("Player");
        print("找到tag为Player对象的个数" +  objs.Length);

        //还有几个查找对象相关是用的比较少的方法 是GameObject父类 Object提供的方法
        //引出额外知识点 Unity中的object和c#中的万物之父的区别
        //Unity里面的object 不是指的万物之父object
        //Unity里的Object 命名空间在UnityEngine中的 Object类 也是集成万物之父的一个自定义类
        //c#中的object 命名空间是在System中的

        Lesson04 o = GameObject.FindObjectOfType<Lesson04>();
        print(o.gameObject.name);

        //实例化对象（克隆对象）的方法
        //实例化(克隆)对象 它的作用 是根据一个GameObject对象 创建出一个和它一模一样的对象
        GameObject obj5 =  GameObject.Instantiate(myobj);
        //以后学了更多的知识点 就可以在这里操作obj5了
        //如果你继承了 MonoBehavior 其实可以不用写GameObject一样可以使用
        //因为这个方法是Unity里面的 Object基类提供给我们的 所以可以直接用
        //Instantiate(myobj);
        //删除对象的方法
        GameObject.Destroy(myobj2);
        //第二个参数表示延时时间秒
        GameObject.Destroy(obj5, 5);
        //Destroy不仅可以删除对象 还可以删除脚本
        //GameObject.Destroy(this);

        //删除对象有两种作用
        //1.是删除指定的一个游戏对象
        //2.是删除一个指定的脚本对象
        //注意:这个Destroy方法 不会马上移除对象 只是给这个对象加了一个移除标识
        //一般情况下 它会在下一帧时把这个对象移除并从内存中移除

        //如果没有特殊需求 就是一定要马上移除一个对象的话
        //建议使用上面的 Destroy方法 因为 是异步的 降低卡顿的几率
        //下面这个方法 就是立即把对象 从内存中移除了
        //GameObject.DestroyImmediate(myobj);

        //如果是继承MonoBehaviour 不用写GameObject
        //Destroy(myobj2);
        //DestroyImmediate(MyObj);

        //过场景不移除
        //默认情况 在切换场景时 场景中对象都会被自动删除掉
        //如果你希望某个对象 过场景不被移除
        //下面这句代码 就是不想谁过场景被移除 就传谁
        //一般都传 依附的GameObject对象
        //比如下面这句代码的意思 就是自己依附的GameObject对象 过场景不被移除
        GameObject.DontDestroyOnLoad(this.gameObject);
        //如果是继承MonoBehaviour，也可以直接写
        //DontDestroyOnLoad(this.gameObject);

        #endregion

        #region 知识点三 GameObject中的成员方法
        //创建空物体
        //new一个GameObject就是在创建一个空物体
        GameObject obj6 = new GameObject();
        GameObject obj7 = new GameObject("代码创建的空物体");
        GameObject obj8 = new GameObject("顺便加脚本的空物体", typeof(Lesson02), typeof(Lesson01));
       
        //为对象添加脚本
        //继承MonoBehaviour的脚本 是不能够去new
        //如果想要动态的添加继承MonoBehaviour的一个叫脚本 在某一个对象上
        //直接使用GameObjec提供的方法即可
        Lesson01 les1 = obj6.AddComponent(typeof(Lesson01)) as Lesson01;
        //用泛型更方便
        Lesson02 les2 = obj6.AddComponent<Lesson02>();
        //通过返回值 可以得到加入的脚本信息
        //来进行一些处理

        //得到脚本的成员方法 和继承Mono的类得到脚本的方法 一摸一样
        
        //标签比较
        //下面两种比较的方法是一样的
        if (this.gameObject.CompareTag("Player"))
        {
            print("对象的标签 是 Player");
        }

        if (this.gameObject.tag == "Player")
        {
            print("对象的标签 是 Player");
        }

        //设置激活失活
        //false 失活
        //true 激活
        obj6.SetActive(false);
        obj7.SetActive(false);
        obj8.SetActive(false);

        //次要的成员方法 了解即可 不建议使用
        //强调
        //下面讲的方法 都不建议大家使用 效率比较低
        //通过广播或者发送消息的形式 让自己或者别人 执行某些行为方法

        //通知自己 执行什么行为
        //命令自己 去执行这个TestFun这个函数 会在自己身上挂载的所有脚本去找这个名字的函数
        //它回去找到 自己身上所有的脚本 有这个名字的函数去执行
        this.gameObject.SendMessage("TestFun");
        this.gameObject.SendMessage("TestFun2",199);

        //广播行为 让自己和自己的子对象执行
        //this.gameObject.BroadcastMessage("函数名")
        
        //向父对象和自己发送消息 并执行
        //this.gameObject.SendMessageUpwards("函数名");
        
        #endregion
    }

    void TestFun()
    {
        print("Lesson04的TestFun");
    }

    void TestFun2(int a)
    {
        print("Lesson04的TestFun" + a);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //总结
    //GameObject的常用内容

    //基本成员变量
    //名字 失活激活状态 标签 层级 等等

    //静态方法相关
    //创建自带几何体
    //查找场景中对象
    //实例化对象
    //删除对象
    //过场景不移除

    //成员方法
    //为对象 动态添加指定脚本
    //设置失活激活的状态
    //和MonoBehavior中相同的 得到脚本相关的方法

}
