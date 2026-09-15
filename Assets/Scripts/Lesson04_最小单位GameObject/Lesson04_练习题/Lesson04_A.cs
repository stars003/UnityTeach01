using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public enum E_Do_Type
{
    改名,
    失活,
    延时删除,
    删除
}


public class Lesson04_A : MonoBehaviour
{
    public E_Do_Type type = E_Do_Type.改名;
    public GameObject 对象;
    public string 名称;

    // Start is called before the first frame update
    void Start()
    {
        switch (type)
        {
            case E_Do_Type.改名:
                if (名称 != "")
                    对象.name = 名称;
                break;
            case E_Do_Type.失活:
                对象.SetActive(false);
                break;
            case E_Do_Type.延时删除:
                Destroy( 对象 , 3 );
                break;
            case E_Do_Type.删除:
                DestroyImmediate(对象);
                break;
            default:
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
