using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public static class TransFormL
{

}


public class Lesson09_练习题 : MonoBehaviour
{

    #region 练习题一
    //请为Transform写一个拓展方法,可以将它的子对象按名字的长短进行
    //排序改变他们的顺序, 名字短的在前面, 名字长的在后面
    #endregion

    #region 练习题二
    //请为Transform写一个拓展方法,传入一个名字查找子对象,即使是子
    //对象的子对象也能查找到

    #endregion

    // Start is called before the first frame update
    void Start()
    {
        this.transform.Sort();

    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
