using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;

public class QuitGame : MonoBehaviour {

    public Transform floatTips;
    public Toggle tg_1;
    public static bool isOk;
    void Start()
    {
        //Camera.main.GetComponent<AudioSource>().Play();//获取相机下的AudioSource组件，并播放（背景音乐）
        isOk = true;
    }
    public void StopAudio()
    {
        if (!tg_1.isOn)
        {
            Camera.main.GetComponent<AudioSource>().Stop();
            isOk = false;
        }

        else if (tg_1.isOn)
        {
            Camera.main.GetComponent<AudioSource>().Play();
            isOk = true;
        }

    }
    public void ShowMenu()
    {
        floatTips.DOLocalMoveY(-528, 0.5f);
    }
    public void CloseMenu()
    {
        floatTips.DOLocalMoveY(-1294, 0.5f);
    }
}
