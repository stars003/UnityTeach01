using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class 炮弹 : MonoBehaviour
{
<<<<<<< Updated upstream
=======
    public float 速度 = 10f;
    public float 射程 = 100f;
>>>>>>> Stashed changes

    private Vector3 startPos;
    //private Vector3 zAxisDir;

<<<<<<< Updated upstream
    private float 射程 = 100f;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "地面")
        {
            Destroy(this.gameObject);
        }
=======
    //private void OnCollisionEnter(Collision collision)
    //{
    //    //问题一:如果发射子弹时 和坦克自身的碰撞和重合了 可能一开始 就会被移除 
    //    //解决方案:判断自己碰撞到的对象 是什么 一定是特定对象 才移除自己
    //    if (collision.gameObject.CompareTag("地面"))
    //    {
    //        //碰撞到别的东西 就让子弹消失
    //        //一定是移除自己依附的GameObject 而不是脚本自己
    //        Destroy(this.gameObject);
    //    }
    //    //问题二:坦克本身就带有碰撞盒 当子弹和坦克自身的碰撞盒碰撞可能会产生力的作用 出现一些意想不到的效果
    //    //解决方案:把子弹做成触发器 这样就没有了力的作用
    //}


    private void OnTriggerEnter(Collider other)
    {
        //问题一:如果发射子弹时 和坦克自身的碰撞和重合了 可能一开始 就会被移除 
        //解决方案:判断自己碰撞到的对象 是什么 一定是特定对象 才移除自己
        if (other.gameObject.CompareTag("地面") || other.gameObject.CompareTag("Monster"))
        {
            //碰撞到别的东西 就让子弹消失
            //一定是移除自己依附的GameObject 而不是脚本自己
            Destroy(this.gameObject);
        }
        //问题二:坦克本身就带有碰撞盒 当子弹和坦克自身的碰撞盒碰撞可能会产生力的作用 出现一些意想不到的效果
        //解决方案:把子弹做成触发器 这样就没有了力的作用
>>>>>>> Stashed changes
    }

    // Start is called before the first frame update
    void Start()
    {
        startPos = transform.position;
        //zAxisDir = transform.up;
    }

    // Update is called once per frame
    void Update()
    {
<<<<<<< Updated upstream
=======
        this.transform.Translate(Vector3.forward * 速度 * Time.deltaTime);

>>>>>>> Stashed changes
        if (Vector3.Distance(startPos, transform.position) >= 射程)
        {
            Destroy(this.gameObject);
        }
    }
}
