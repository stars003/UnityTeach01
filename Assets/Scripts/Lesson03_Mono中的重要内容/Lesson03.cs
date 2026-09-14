using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson03 : MonoBehaviour
{
    public Lesson03 otherLesson03;
    // Start is called before the first frame update
    void Start()
    {
        #region 知识点一 重要成员
        //1、获取依附的游戏对象GameObject
        print(this.gameObject.name);
        //2、获取依附的GameObject的位置信息
        //得到对象位置信息
        print(this.transform.position);//位置
        print(this.transform.eulerAngles);//角度
        print(this.transform.lossyScale);//缩放

        //这种写法和上面是一样的效果 都是得到衣服的对象的位置信息
        //this.gameObject.transform

        //3、获取脚本是否激活
        this.enabled = false;//禁用脚本

        //获取别的脚本的对象 依附的gameobject和 transform的位置信息
        print(otherLesson03.gameObject.name);
        print(otherLesson03.transform.position);

        #endregion

        #region 知识点二 重要方法
        //得到依附对象上挂载得的其它脚本
        //1、得到自己挂载的单个脚本
        //根据脚本名获取
        //获取脚本的方法 如果获取失败 就是没有对应的脚本 会默认返回null
        Lesson03_Test t =  this.GetComponent("Lesson03_Test") as Lesson03_Test;
        print(t);
        t = this.GetComponent(typeof(Lesson03_Test)) as Lesson03_Test;
        print(t);

        //根据泛型获取 建议使用泛型获取 因为不用二次转换
        t = this.GetComponent<Lesson03_Test>();
        print(t);

        //2、得到自己挂载的多个脚本
        Lesson03[] array = this.GetComponents<Lesson03>();
        print(array.Length);
        List<Lesson03> list = new List<Lesson03>();
        this.GetComponents<Lesson03>(list);
        print(list.Count);
        //3、得到依附对象上挂载的其它组件(默认也会找自己身上是否挂载了该脚本)
        //函数是有一个参数的 默认不传 是false 意思就是 如果对象失活 是不会去找这个对象上是否有某个脚本的
        //如果传true 就是即使对象失活 也会去找这个对象上是否有某个脚本的
        t = this.GetComponentInChildren<Lesson03_Test>(true);
        print(t);

        Lesson03_Test[] lts = this.GetComponentsInChildren<Lesson03_Test>(true);
        print(lts.Length);

        List<Lesson03_Test> list2 = new List<Lesson03_Test>();
        this.GetComponentsInChildren<Lesson03_Test>(true,list2);
        print(list2.Count);

        //4、得到父对象挂载的脚本(默认也会找自己身上是否挂载了该脚本)
        t = this.GetComponentInParent<Lesson03_Test>();
        print(t);

        lts = this.GetComponentsInParent<Lesson03_Test>();
        print(lts.Length);


        //5、尝试获取脚本
        Lesson03_Test l3t = null;
        //提供里一个更加安全的 获取脚本的方法 如果得到了 会返回true
        //然后再来进行逻辑处理
        if (this.TryGetComponent<Lesson03_Test>(out l3t)) 
        {
            //逻辑处理
        }
        #endregion

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
