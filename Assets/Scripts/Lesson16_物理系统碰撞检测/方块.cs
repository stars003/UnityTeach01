using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class 方块 : MonoBehaviour
{
    public int HP = 3;

    private void OnTriggerEnter(Collider other)
    {
        //当子弹碰到方块时, 方块的血量减少, 当血量小于等于0时, 方块消失
        if (other.gameObject.name == "炮弹(Clone)")
        {
            //由于场景上 只有子弹时触发器 所以我们可以不用进行任何判断 就可以完成这个功能
            //减血
            --HP;
            //为0就移除自己
            if (HP <= 0)
            {
                Destroy(this.gameObject);
            }
        }
    }

}
