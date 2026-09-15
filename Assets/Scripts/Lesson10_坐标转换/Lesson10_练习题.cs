using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson10_练习题 : MonoBehaviour
{
    #region 练习题一
    //一个物体A，不管它在什么位置，写一个方法，只要执行这个方法就可
    //以在它的左前方（-1,0,1）处创建一个空物体
    [ContextMenu("左前方陷阱")]
    public void 陷阱()
    {
        GameObject xj = new GameObject("空物体");
        xj.transform.position = this.transform.TransformPoint(new Vector3(-1,0,1));
    }
    #endregion

    #region 练习题二
    //一个物体A，不管它在什么位置，写一个方法，只要执行这个方法就可
    //以在它的前方创建出3个球体, 位置分别是（0, 0, 1）,（0, 0, 2）,
    //（0, 0, 3）

    [ContextMenu("三个敌人")]
    public void 遇敌()
    {
        GameObject d1 = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        GameObject d2 = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        GameObject d3 = GameObject.CreatePrimitive(PrimitiveType.Sphere);

        d1.transform.position = this.transform.TransformPoint(new Vector3(0, 0, 1));
        d2.transform.position = this.transform.TransformPoint(new Vector3(0, 0, 2));
        d3.transform.position = this.transform.TransformPoint(new Vector3(0, 0, 3));
    }

    #endregion


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
