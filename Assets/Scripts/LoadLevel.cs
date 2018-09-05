using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadLevel : MonoBehaviour {

    //private void Start()
    //{
    //    if(QuitGame.isOk == true)
    //    Camera.main.GetComponent<AudioSource>().Play();//获取相机下的AudioSource组件，并播放（背景音乐）
    //    else
    //    Camera.main.GetComponent<AudioSource>().Stop();
    //}


    public void LoadMenu()
    {
        SceneManager.LoadScene(0);
    }
    public void LoadChooseLevel()
    {
        SceneManager.LoadScene(1);
    }
    public void LoadLevel3_3()
    {
        SceneManager.LoadScene(2);
    }
    public void LoadLevel4_4()
    {
        SceneManager.LoadScene(3);
    }
    public void LoadLevel5_5()
    {
        SceneManager.LoadScene(4);
    }
    public void LoadHighScore()
    {
        SceneManager.LoadScene(5);
    }

}
