using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class A : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        if (this.TryGetComponent<B>(out B b))
            b.enabled = false;        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
