using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class 炮弹 : MonoBehaviour
{

    private Vector3 startPos;
    //private Vector3 zAxisDir;

    private float 射程 = 100f;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "地面")
        {
            Destroy(this.gameObject);
        }
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
        if (Vector3.Distance(startPos, transform.position) >= 射程)
        {
            Destroy(this.gameObject);
        }
    }
}
