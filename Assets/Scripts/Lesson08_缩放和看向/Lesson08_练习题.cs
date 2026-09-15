using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson08_练习题 : MonoBehaviour
{
    public Transform objT;
    //使用之前的坦克预设体,让摄像机可以跟随其移动,并且一直看向坦克

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.LookAt(objT);
        objT.Translate(Vector3.forward * 1 * Time.deltaTime, Space.Self);
    }
}
