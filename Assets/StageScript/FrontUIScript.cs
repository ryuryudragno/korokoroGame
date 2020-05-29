﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class FrontUIScript : MonoBehaviour
{
    public GameObject nextBtn;
    public GameObject selectBtn;
    public GameObject titleBtn;
    public GameObject retryBtn;
    public AudioClip selectSound;
    AudioSource audioSource;

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
        retryBtn.SetActive(false);
        audioSource = GetComponent<AudioSource>();
        /*
        nextBtn.interactable = false;
        selectBtn.interactable = false;
        */
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ClearAppearButton()
    {
        nextBtn.SetActive(true);
        selectBtn.SetActive(true);
        titleBtn.SetActive(true);

        /*
        nextBtn.interactable = true;
        selectBtn.interactable = true;
        */
    }
    public void  GameOverAppearButton()
    {
        retryBtn.SetActive(true);
        selectBtn.SetActive(true);
        titleBtn.SetActive(true);
    }
    public void BackToTitle()
    {
        SceneManager.LoadScene("Title");
    }
    /*ステージ選択画面へ*/
    public void MoveToStageSelect()
    {
        StartCoroutine("StageSelect");
        audioSource.PlayOneShot(selectSound);
    }
    IEnumerator StageSelect()
    {
        yield return new WaitForSeconds(1.5f);
        SceneManager.LoadScene("StageSelect");
    }
    /*リトライ*/
    public void Retry()
    {
        StartCoroutine("Stage1");
        audioSource.PlayOneShot(selectSound);
    }
    IEnumerator Stage1()
    {
        yield return new WaitForSeconds(1.5f);
        SceneManager.LoadScene("Stage1");
    }
}