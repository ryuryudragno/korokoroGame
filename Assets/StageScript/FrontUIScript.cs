using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class FrontUIScript : MonoBehaviour
{
    public GameObject nextBtn;
    public GameObject selectBtn;
    public GameObject titleBtn;

    /*
    public Button nextBtn;
    public Button selectBtn;
    */

    // Start is called before the first frame update
    void Start()
    {
        nextBtn.SetActive(false);
        selectBtn.SetActive(false);
        titleBtn.SetActive(false);

        /*
        nextBtn.interactable = false;
        selectBtn.interactable = false;
        */
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AppearButton()
    {
        nextBtn.SetActive(true);
        selectBtn.SetActive(true);
        titleBtn.SetActive(true);

        /*
        nextBtn.interactable = true;
        selectBtn.interactable = true;
        */
    }
    public void BackToTitle()
    {
        SceneManager.LoadScene("Title");
    }
}
