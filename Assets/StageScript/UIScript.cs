using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIScript : MonoBehaviour
{
    public Text timerText;
    float timer = 30;
    public bool timeStop = false;
    // Start is called before the first frame update
    void Start()
    {
        timerText.text = "30";
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        timerText.text = timer.ToString("f0");

        if(timer <= 0)
        {
            timerText.text = "GameOver";
            GameObject.FindObjectOfType<FieldScript>().enabled = false;
            GameObject.FindObjectOfType<SphereScript>().enabled = false;
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
        Debug.Log("読んだ？");
    }

}
