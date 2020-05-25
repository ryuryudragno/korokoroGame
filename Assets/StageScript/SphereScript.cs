using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereScript : MonoBehaviour
{
    //public float posY;
    public Vector3 StartPosition;

    // Start is called before the first frame update
    void Start()
    {
        StartPosition = transform.position;
        //posY = this.transform.position.y;
    }

    // Update is called once per frame
    void Update()
    {
        if(this.gameObject.transform.position.y < -10)
        {
            transform.position = StartPosition;
        }
    }
}
