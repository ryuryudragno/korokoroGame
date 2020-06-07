using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereScript : MonoBehaviour
{
    //public float posY;
    public Vector3 StartPosition;
    Rigidbody rigidbody;
    /*
    public AudioClip dropOutSound;
    AudioSource audioSource;
    */
    bool stopBall = false;

    // Start is called before the first frame update
    void Start()
    {
        StartPosition = transform.position;
        rigidbody = this.GetComponent<Rigidbody>();
        
        //posY = this.transform.position.y;
    }

    // Update is called once per frame
    void Update()
    {
        if(this.gameObject.transform.position.y < -10)
        {
            DropOut();
        }
    }

    void DropOut()
    {
        transform.position = StartPosition + new Vector3(0,5,0);
        this.rigidbody.velocity = new Vector3(0, 0, 0);
        GameObject.FindObjectOfType<FieldScript>().ballOut();
        GameObject.FindObjectOfType<UIScript>().timeMinus();
    }
    public void Destroy()
    {
        Destroy(this.gameObject);
    }
}
