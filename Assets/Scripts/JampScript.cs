using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JampScript : MonoBehaviour
{
    public AudioClip jampSoundEffect;
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
        if (other.gameObject.tag == "Player")
        {
            Rigidbody rigidbody = other.gameObject.GetComponent<Rigidbody>();
            Vector3 force = new Vector3(0.0f, 15.0f, 0.0f);
            rigidbody.AddForce(force, ForceMode.Impulse);
            audioSource.PlayOneShot(jampSoundEffect);

            Debug.Log("Jamp");
            //GameObject.FindObjectOfType<UIScript>().timePlusJamp();
        }
    }
}
