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
            if(InBallNumber == AllBallNumber)
            {
                Debug.Log("clear");
                clearText.text = "Clear!!";
            }
            audioSource.PlayOneShot(holeSoundEffect);
            Debug.Log("clear");
        }
    }
}
