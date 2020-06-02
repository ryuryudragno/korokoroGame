using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BGMScript : MonoBehaviour
{
    AudioSource audioSource;
    //public AudioClip gameOverSound;

    // Use this for initialization
    void Start()
    {
        //画面遷移してもオブジェクトが壊れないようにする
        //DontDestroyOnLoad(this);
        audioSource = GetComponent<AudioSource>();
    }
    public void StopBGM()
    {
        audioSource.Stop();
    }
    /*public void GameOverSound()
    {
        audioSource.PlayOneShot(gameOverSound);
    }*/
}
