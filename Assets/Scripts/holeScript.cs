using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class holeScript : MonoBehaviour
{
    public Text clearText;
    public int InBallNumber = 0;
    public int AllBallNumber;
    public AudioClip holeSoundEffect;
    public AudioClip clearSound;
    public AudioClip gameOverSound;
    AudioSource audioSource;
    public Button pauseButton;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            InBallNumber += 1;
            Destroy(other.gameObject);
            audioSource.PlayOneShot(holeSoundEffect);
            if (InBallNumber == AllBallNumber)
            {
                gameClear();
            }
            else
            {
                //audioSource.PlayOneShot(holeSoundEffect);
                GameObject.FindObjectOfType<TimeScript>().timePlus();
            }
            //Debug.Log("clear");
        }
    }

    void gameClear()
    {
        GameObject.FindObjectOfType<UnlockScript>().Unlock();
        //Debug.Log("clear");
        clearText.text = "Clear!!";
        audioSource.PlayOneShot(clearSound);
        GameObject.FindObjectOfType<FieldScript>().enabled = false;
        GameObject.FindObjectOfType<TimeScript>().gameFin();
        GameObject.FindObjectOfType<FrontUIScript>().ClearAppearButton();
        GameObject.FindObjectOfType<BGMScript>().StopBGM();
        GameObject.FindObjectOfType<StageManager>().stageClearUpdate();
        pauseButton.interactable = false;
        GameObject.FindObjectOfType<AdvertiseScript>().ShowRewardedAd();
    }

    public void GameOverSound()
    {
        audioSource.PlayOneShot(gameOverSound);
    }
}
