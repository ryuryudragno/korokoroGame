using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StageSelectScript : MonoBehaviour
{
    public Button stage1button;
    public Button stage2button;
    public Button stage3button;
    public Button stage4button;
    public Button stage5button;
    public Button stage6button;
    public AudioClip selectSound;
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

    public void MoveToStage1()
    {
        StartCoroutine("Stage1");
        audioSource.PlayOneShot(selectSound);
    }
    IEnumerator Stage1()
    {
        yield return new WaitForSeconds(1.5f);
        SceneManager.LoadScene("Stage1");
    }

    public void MoveToStage2()
    {
        StartCoroutine("Stage2");
        audioSource.PlayOneShot(selectSound);
    }
    IEnumerator Stage2()
    {
        yield return new WaitForSeconds(1.5f);
        SceneManager.LoadScene("Stage2");
    }

    public void MoveToStage3()
    {
        StartCoroutine("Stage3");
        audioSource.PlayOneShot(selectSound);
    }
    IEnumerator Stage3()
    {
        yield return new WaitForSeconds(1.5f);
        SceneManager.LoadScene("Stage3");
    }
    public void MoveToStage4()
    {
        StartCoroutine("Stage4");
        audioSource.PlayOneShot(selectSound);
    }
    IEnumerator Stage4()
    {
        yield return new WaitForSeconds(1.5f);
        SceneManager.LoadScene("Stage4");
    }
    public void MoveToStage5()
    {
        StartCoroutine("Stage5");
        audioSource.PlayOneShot(selectSound);
    }
    IEnumerator Stage5()
    {
        yield return new WaitForSeconds(1.5f);
        SceneManager.LoadScene("Stage5");
    }
    public void MoveToStage6()
    {
        StartCoroutine("Stage6");
        audioSource.PlayOneShot(selectSound);
    }
    IEnumerator Stage6()
    {
        yield return new WaitForSeconds(1.5f);
        SceneManager.LoadScene("Stage6");
    }
}
