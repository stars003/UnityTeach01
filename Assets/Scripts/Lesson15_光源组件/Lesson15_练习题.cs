using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class Lesson15_练习题 : MonoBehaviour
{
    public Light pointLight; //点光源
    public Light light1; //灯芯
    public float moveSpeed; //点光源移动速度
    public Light directionalLight; //方向光源

    // Start is called before the first frame update
    void Start()
    {
        moveSpeed = 0.05f;
        //light1 = GameObject.Find("Point Light").GetComponent<Light>();
        //2.通过代码结合方向光 模拟白天黑夜的变化
    }

    // Update is called once per frame
    void Update()
    {
        #region 练习题一
        //1.通过代码结合点光源 模拟一个蜡烛的光源效果
        if (pointLight != null && light1 != null)
        {
            pointLight.transform.Translate(Vector3.right * moveSpeed * Time.deltaTime);
            light1.transform.Translate(Vector3.right * moveSpeed * Time.deltaTime);
            if (pointLight.transform.position.x >= 0.08f)
            {
                moveSpeed = -moveSpeed;
            }
            else if (pointLight.transform.position.x <= -0.08f)
            {
                moveSpeed = -moveSpeed;
            }
            pointLight.intensity = Mathf.PingPong(Time.time, 1.0f) + 0.5f; //点光源的强度在0.5-1.5之间变化
        }

        #endregion

        directionalLight.transform.Rotate(Vector3.right * Time.deltaTime * 10); //方向光源绕x轴旋转

        //directionalLight.intensity = Mathf.PingPong(Time.time / 24, 1.0f); //方向光源的强度在0.0-1.0之间变化
    }
}
