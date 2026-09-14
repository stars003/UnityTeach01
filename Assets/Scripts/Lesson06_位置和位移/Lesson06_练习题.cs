using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;

public class Lesson06_练习题 : MonoBehaviour
{
    #region 练习题一
    //1.一个空对象上挂了一个脚本,这个脚本可以让游戏运行时,在场景中
    //创建出一个n层由Cube构成的金字塔(提示:实例化预设体或者实例化
    //自带几何体方法)
    public GameObject obj;
    public int 层数 = 7;
    //public int stk = floors * (floors + 1) * (2 * floors + 1) / 6;
    //public GameObject[] goldTower = new GameObject[stk];
    //private int num = 0;
    private float x = 10;
    private float y = 0;
    private float z = 10;

    private float xT = 0;
    //private float yT = 0;
    private float zT = 0;

    #endregion

    #region 练习题二
    //2.
    //this.transform.Translate(Vector3.forward, Space.World);
    //this.transform.Translate(Vector3.forward, Space.Self);
    //this.transform.Translate(this.transform.forward, Space.Self);
    //this.transform.Translate(this.transform.forward, Space.World);
    //这四个方法,哪些才能让对象朝自己的面朝向移动?为何?(可以画图说明)

    #endregion

    #region 练习题三
    //3.使用你之前创建的坦克预设体,让其可以朝自己的面朝向向前移动

    #endregion

    // Start is called before the first frame update
    void Start()
    {
        //绘制金字塔A
        Vector3 posT = new Vector3(x, y, z);
        for (int i = 层数; i > 0; i--)
        {
            for (int j = 0; j < i; j++)
            {
                z = zT + j;
                for (int k = 0; k < i; k++)
                {
                    x = xT + k;
                    GameObject jzt = GameObject.CreatePrimitive(PrimitiveType.Cube);
                    jzt.name = "砖块" + i + "_" + j + "_" + k;
                    jzt.transform.position = new Vector3(x, y, z) + posT;
                }
            }
            y += 1;
            xT += 0.5f;
            zT += 0.5f;
        }

        //绘制金字塔B
        for (int i = 层数; i > 0; i--)
        {
            //初始坐标
            Vector3 pos = new Vector3(0.5f * (层数 - i), 层数 - i, 0.5f * (层数 - i));
            for (int j = 0; j < i*i; j++)
            {
                //实例化
                GameObject jzt = GameObject.CreatePrimitive(PrimitiveType.Cube);
                //设置位置
                jzt.transform.position = new Vector3(j % i * 1, 0, j / i * 1) + pos;
                jzt.name = "砖块" + i + "层_" + j + 1 + "块";

            }
        }

        GameObject tank = Instantiate(obj);
        tank.transform.position = new Vector3(10, 0, 10);
        TankMove tkmS = tank.AddComponent<TankMove>();

    }

    // Update is called once per frame
    void Update()
    {

    }
}
