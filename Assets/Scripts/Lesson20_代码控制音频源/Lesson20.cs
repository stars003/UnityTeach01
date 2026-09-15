using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson20 : MonoBehaviour
{
    AudioSource audioSource;

    public GameObject obj;

    public AudioClip clip1;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = this.GetComponent<AudioSource>();

        #region 知识点三 如何动态控制音效播放
        //1.直接在要播放音效的对象上挂載脚本 控制播放

        //2.实例化挂载了音效源脚本的对象
        //这种方法 其实用的比较少
        //Instantiate(obj);

        //3.用一个AudioSource来控制播放不同的音效
        //AudioSource aus = this.gameObject.AddComponent<AudioSource>();
        //aus.clip = clip1;
        //aus.Play();

        //潜在知识点 
        //一个GameObject可以挂载多个 音效源脚本AudioSource 
        //使用时要注意 如果要挂载多个 那一定要自己管理他们
        //控制他们的播放停止 不然 我们没有办法准确的获取 谁是谁

        #endregion

    }

    // Update is called once per frame
    void Update()
    {
        #region 知识点一 代码控制播放停止
        if (Input.GetKeyDown(KeyCode.P))
        {
            //播放音效
            audioSource.Play();
            //延时播放 填写的是秒数
            //audioSource.PlayDelayed(3);
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            //停止音效
            audioSource.Stop();
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //暂停音效
            audioSource.Pause();
        }
        if (Input.GetKeyDown(KeyCode.X))
        {
            //停止暂停 和暂停后 Play效果是一样的 都会继续播放现在的音效
            audioSource.UnPause();
        }

        #endregion

        #region 知识点二 如何检测音效播放完毕
        if (audioSource.isPlaying)
        {
            print("音效正在播放");
        }
        else
        {
            print("音效播放结束");
        }
        #endregion

    }
}
