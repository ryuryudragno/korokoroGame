using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIScript : MonoBehaviour
{
    public Text timerText;
    public Text clearText;
    float timer = 30;
    public bool timeStop = false;
    //GameObject gameObject;

    // Start is called before the first frame update
    void Start()
    {
        timerText.text = "30";
        //gameObject = GameObject.Find("MainCamera");
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        timerText.text = timer.ToString("f0");

        if(timer <= 0)
        {
            gameOver();
        }
        if (timeStop == true)
        {
            enabled = false;
        }

    }

    public void timePlus()
    {
        timer += 10;
    }
    public void timeMinus()
    {
        timer -= 5;
    }

    public void gameFin()//クリアしてもゲームオーバーしても呼ばれる
    {
        timeStop = true;
    }
    void gameOver()
    {
        clearText.text = "GameOver";
        timerText.text = "";
        FindObjectOfType<FieldScript>().enabled = false;
        //FindObjectOfType<SphereScript>().enabled = false;
        FindObjectOfType<holeScript>().enabled = false;
        FindObjectOfType<FrontUIScript>().GameOverAppearButton();
        FindObjectOfType<holeScript>().GameOverSound();

        GameObject[] Spheres = GameObject.FindGameObjectsWithTag("Player");
        for (int i = 0; i < Spheres.Length; i++)
        {
            Destroy(Spheres[i]);
        }
        GameObject.FindObjectOfType<BGMScript>().StopBGM();
    }
}
