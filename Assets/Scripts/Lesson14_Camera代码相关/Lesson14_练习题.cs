using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson14_练习题 : MonoBehaviour
{
    //public Transform obj;
    // Start is called before the first frame update
    void Start()
    {
        //1.游戏画面中央有一个立方体，请将该立方体的世界坐标系位置，转换
        //为屏幕坐标, 并打印出来
        print(Camera.main.WorldToScreenPoint(this.transform.position));


    }

    // Update is called once per frame
    void Update()
    {
        //2.在屏幕上点击一下鼠标，则在对应的世界坐标位置 创建一个Cube出
        //来
        Vector3 v = Input.mousePosition;
        v.z = 10;
        if (Input.GetMouseButtonDown(0))
        {
            GameObject obj = GameObject.CreatePrimitive(PrimitiveType.Cube);
            obj.name = "我创建的立方体";
            obj.transform.position = Camera.main.ScreenToWorldPoint(v);
        }
    }
}
