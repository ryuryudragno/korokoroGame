using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StageManager : MonoBehaviour
{

    public int stage_num; // スコア変数
    public GameObject two;
    public GameObject three;
    public GameObject four;
    public GameObject five;
    public GameObject six;
    public GameObject twoP;
    public GameObject threeP;
    public GameObject fourP;
    public GameObject fiveP;
    public GameObject sixP;

    // Use this for initialization
    void Start()
    {
        //現在のstage_numを呼び出す
        stage_num = PlayerPrefs.GetInt("SCORE", 0);
        Debug.Log(stage_num);
    }

    // Update is called once per frame
    void Update()
    {
        //stage_numが２以上のとき、ステージ２を解放する。以下同様
        if (stage_num >= 2)
        {
            two.SetActive(true);
            twoP.SetActive(false);
        }

        if (stage_num >= 3)
        {
            three.SetActive(true);
            threeP.SetActive(false);
        }

        if (stage_num >= 4)
        {
            four.SetActive(true);
            fourP.SetActive(false);
        }

        if (stage_num >= 5)
        {
            five.SetActive(true);
            fiveP.SetActive(false);
        }
        if (stage_num >= 6)
        {
            six.SetActive(true);
            sixP.SetActive(false);
        }
    }
    public void stageClearUpdate()
    {
        stage_num = PlayerPrefs.GetInt("SCORE", 0);

        switch (SceneManager.GetActiveScene().name)
        {
            case "Stage1":
                //PlayerPrefsのSCOREに2という値を入れる
                if (stage_num < 2)
                {
                    PlayerPrefs.SetInt("SCORE", 2);
                    Debug.Log("反応したよ");
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
                    PlayerPrefs.SetInt("SCORE", 3);
                }
                break;

            case "Stage3":
                if (stage_num < 4)
                {
                    PlayerPrefs.SetInt("SCORE", 4);
                }
                break;

            case "Stage4":
                if (stage_num < 5)
                {
                    PlayerPrefs.SetInt("SCORE", 5);
                }
                break;

            case "Stage5":
                if (stage_num < 6)
                {
                    PlayerPrefs.SetInt("SCORE", 6);
                }
                break;

            //デフォルト処理
            default:
                //処理Default
                Debug.Log("Default");
                //break文
                break;
        }

        //初期化したいときこの行↓をコメントはずす
        PlayerPrefs.SetInt("SCORE", 0);

        //PlayerPrefsをセーブする
        PlayerPrefs.Save();
    }
}
