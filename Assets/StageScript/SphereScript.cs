using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereScript : MonoBehaviour
{
    //public float posY;

    // Start is called before the first frame update
    void Start()
    {
        //posY = this.transform.position.y;
    }

    // Update is called once per frame
    void Update()
    {
        if(this.gameObject.transform.position.y < -10)
        {
            transform.position = new Vector3(0, 4, 0);
        }
    }
}
