using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TitleSphere : MonoBehaviour
{
    //public float posY;
    public Vector3 StartPosition;
    Rigidbody rigidbody;
    
    // Start is called before the first frame update
    void Start()
    {
        StartPosition = transform.position;
        rigidbody = this.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (this.gameObject.transform.position.y < -10)
        {
            DropOut();
        }
    }

    void DropOut()
    {
        transform.position = StartPosition;
        this.rigidbody.velocity = new Vector3(0, 0, 0);
    }
}
