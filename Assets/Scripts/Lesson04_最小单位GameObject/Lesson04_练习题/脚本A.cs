using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class 脚本A : MonoBehaviour
{
    //public GameObject obj;
    //public string name = obj.name;


    // Start is called before the first frame update
    void Start()
    {
        GameObject objB = GameObject.Find("对象B");
        if (objB != null)
        {
            脚本B jbb;
            if (objB.TryGetComponent<脚本B>(out jbb))
            {
                jbb.enabled = false;
            }

            //objB.GetComponent<脚本B>().enabled = false;
        }
        else
        {
            print("没有找到对应对象");
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
