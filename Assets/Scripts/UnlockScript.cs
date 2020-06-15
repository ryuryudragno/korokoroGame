using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UnlockScript : MonoBehaviour
{

    public int stage_num; // スコア変数
    public Text unlockText;

    // Use this for initialization
    void Start()
    {
        unlockText.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
   
    }
    public void Unlock()
    {
        stage_num = PlayerPrefs.GetInt("SCORE", 0);

        switch (SceneManager.GetActiveScene().name)
        {
            case "Stage1":
                //PlayerPrefsのSCOREに2という値を入れる
                if (stage_num < 2)
                {
                    unlockText.enabled = true;
                }
                else
                {
                    Debug.Log("そのまま");
                }
                //break文
                break;

            case "Stage2":
                if (stage_num < 3)
                {
                    unlockText.enabled = true;
                }
                break;

            case "Stage3":
                if (stage_num < 4)
                {
                    unlockText.enabled = true;
                }
                break;

            case "Stage4":
                if (stage_num < 5)
                {
                    unlockText.enabled = true;
                }
                break;

            case "Stage5":
                if (stage_num < 6)
                {
                    unlockText.enabled = true;
                }
                break;

            //デフォルト処理
            default:
         
                break;
        }
    }
}
