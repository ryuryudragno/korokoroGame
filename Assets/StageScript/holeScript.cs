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
                GameObject.FindObjectOfType<UIScript>().timePlus();
            }
            //Debug.Log("clear");
        }
    }

    void gameClear()
    {
        Debug.Log("clear");
        clearText.text = "Clear!!";
        audioSource.PlayOneShot(clearSound);
        GameObject.FindObjectOfType<FieldScript>().enabled = false;
        GameObject.FindObjectOfType<UIScript>().gameFin();
        GameObject.FindObjectOfType<FrontUIScript>().ClearAppearButton();
        GameObject.FindObjectOfType<BGMScript>().StopBGM();
    }

    public void GameOverSound()
    {
        audioSource.PlayOneShot(gameOverSound);
    }
}
