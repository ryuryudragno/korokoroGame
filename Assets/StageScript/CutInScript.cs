using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CutInScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Awake()
    {
        Time.timeScale = 1;
        FindObjectOfType<FieldScript>().enabled = false;
        FindObjectOfType<holeScript>().enabled = false;
        FindObjectOfType<BGMScript>().enabled = false;
        FindObjectOfType<SphereScript>().enabled = false;
        FindObjectOfType<UIScript>().enabled = false;
        //FindObjectOfType<FieldScript>().enabled = false;
        //FindObjectOfType<FieldScript>().enabled = false;
        //FindObjectOfType<FieldScript>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void GameStart(){
        FindObjectOfType<FieldScript>().enabled = true;
        FindObjectOfType<holeScript>().enabled = true;
        FindObjectOfType<BGMScript>().enabled = true;
        FindObjectOfType<SphereScript>().enabled = true;
        FindObjectOfType<UIScript>().enabled = true;
    }
}
