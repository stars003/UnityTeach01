using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum E_TestEnum
{
    Normal,
    Player,
    Monster
}
[System.Serializable]
public struct MyStruct
{
    public int age;
    public bool sex;
}
[System.Serializable]
public class MyClass
{
    public int age;
    public bool sex;

}

public class Lesson02 : MonoBehaviour
{
    #region 知识点一 私有和保护的不显示和编辑
    private int i1;
    protected string str1;
    #endregion

    #region 知识点二 让私有和保护的显示和编辑
    //通过添加特性可以强制显示私有和保护的变量
    [SerializeField]
    private int privateInt;
    [SerializeField]
    protected string protectedStr;
    #endregion

    #region 知识点三 公共的可以显示编辑
    [HideInInspector]
    public int PublicInt = 10;
    public bool PublicBool = false;
    #endregion

    #region 知识点四 公共的也不让其显示编辑
    //在变量前加上特性
    //[HideInInspector]
    [HideInInspector]
    public int PublicInt2 = 50;

    #endregion.

    #region 知识点五 大部分类型都能够显示和编辑
    public int[] array;
    public List<int> list;
    public E_TestEnum type;
    public GameObject gameObj;

    public Dictionary<int, string> map;
    //自定义类型成员变量
    public MyStruct myStruct;
    public MyClass myClass;
    #endregion

    #region 知识点六 让自定义类型可以被访问
    //加上序列化特性
    //[System.Serializable]
    //字典怎样都不行

    #endregion

    #region 知识点七 一些辅助特性
    //1、分组说明特性 Header
    //为成员分组
    //[Header("这是一个分组")]
    [Header("基础属性")]
    public int age;
    public bool sex;

    [Header("战斗属性")]
    public int atk;
    public int def;


    //2.悬停注释Tooltip
    //为变量添加说明
    //[Tooltip("这是一个悬停注释")]
    [Tooltip("闪避")]
    public int miss;

    //3.间隔特性 Space()
    //为两个字段间添加间隔
    //[Space(20)]
    [Space()]
    public int crit;

    //4.修饰数值的滑条范围 范围特性 Range()
    //[Range(最大值, 最小值)]
    [Range(0, 10)]
    public float luck;

    //5.多行显示字符串 默认不写参数显示3行
    //写上参数就是对应行
    //[Multiline(4)]
    [Multiline()]
    public string tips;

    //6.滚动条显示字符串
    //默认不写参数就是超过三行显示滚动条
    //[TextArea(3, 4)]
    //最少显示3行，最多显示4行，超过4行就显示滚动条
    [TextArea(3, 4)]
    public string myLife;

    //7.为变量添加快捷方法 ContextMenuItem()
    //参数1 显示按钮名
    //参数2 方法名 不能有参数
    //[ContextMenuItem("显示按钮名", "方法名")]
    [ContextMenuItem("重置金币", "ResetMoney")]
    public int money;
    private void ResetMoney()
    {
        money = 99;
    }

    //8.为方法添加特性能够在Inspector中执行
    //[ContextMenu("测试函数")]
    [ContextMenu("哈哈哈哈")]
    private void TestFun()
    {
        print("测试方法");
    }


    //9.为变量添加颜色特性
    //[ColorUsage(true, true)]

    #endregion

    #region 注意
    //1.在Inspector中显示的变量关联的就对象的成员变量，运行时改变他们就是在改变成员变量
    public int i = 200;
    //1、拖拽到GameObject对象后 再改变脚本中变量默认值 界面上不会改变
    //2、运行中修改的变量值，运行结束后会恢复到原来的值，不会保存
    #endregion

    private void Start()
    {
        print(privateInt);
        print(protectedStr);
    }

    private void Update()
    {
        print(i);

    }


}
