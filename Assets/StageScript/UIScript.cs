using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIScript : MonoBehaviour
{
    public Text timerText;
    float timer = 30;
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
    }

    
}
