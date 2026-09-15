using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson04_练习题 : MonoBehaviour
{
    #region 练习题一
    //1.一个空物体上挂了一个脚本,游戏运行时该脚本可以实例化出之前的
    //坦克预设体
    public GameObject obj01;


    #endregion

    #region 练习题二
    //2.一个脚本A一个脚本B，脚本A挂在A对象上，脚本B挂在B对象上
    //实现在A脚本的Start函数中将B对象上的B脚本失活(用GameObject相
    //关知识做)

    #endregion

    #region 练习题三
    //3.一个对象A和一个对象B，在A上挂一个脚本，通过这个脚本可以让B
    //对象改名, 失活, 延迟删除, 立即删除。可以在Inspector窗口进行设
    //置，让B实现不同的效果(提示:GameObject、枚举)

    #endregion



    // Start is called before the first frame update
    void Start()
    {
        GameObject tank01 = Instantiate(obj01);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
