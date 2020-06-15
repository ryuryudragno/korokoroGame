using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PauseScript : MonoBehaviour
{
    [SerializeField]
    private GameObject backBtn;
    [SerializeField]
    private GameObject selectBtn;
    [SerializeField]
    private GameObject titleBtn;
    [SerializeField]
    private GameObject retryBtn;
    [SerializeField]
    private GameObject pausePanel;
    AudioClip selectSound;
    AudioSource audioSource;
    string sceneName;


    // Start is called before the first frame update
    void Start()
    {
        pausePanel.SetActive(false);
        /*
        backBtn.SetActive(false);
        selectBtn.SetActive(false);
        titleBtn.SetActive(false);
        retryBtn.SetActive(false);
        */
        audioSource = GetComponent<AudioSource>();
        sceneName = SceneManager.GetActiveScene().name;
    }

    // Update is called once per frame
    void Update()
    {

    }

    //ボタン表示
    public void PauseAppearButton()
    {
        audioSource.Play();
        Time.timeScale = 0;
        pausePanel.SetActive(true);
    }
    //タイトル画面へ
    public void BackToTitle()
    {
        SceneManager.LoadScene("Title");
        Time.timeScale = 1;
    }
    /*ステージ選択画面へ*/
    public void MoveToStageSelect()
    {
        SceneManager.LoadScene("StageSelect");
        Time.timeScale = 1;
    }
    /*IEnumerator StageSelect()
    {
        yield return new WaitForSeconds(1.5f);
        SceneManager.LoadScene("StageSelect");
    }*/
    /*リトライ*/
    public void Retry()
    {
        SceneManager.LoadScene(sceneName);
        Time.timeScale = 1;
    }
    /*IEnumerator Restart()
    {
        yield return new WaitForSeconds(1.5f);
        SceneManager.LoadScene(sceneName);
    }*/
    //プレイ再開
    public void BackToGame()
    {
        Time.timeScale = 1;
        pausePanel.SetActive(false);
    }
    /*IEnumerator Back()
    {
        yield return new WaitForSeconds(1.5f);
        Time.timeScale = 1;
        pausePanel.SetActive(false);
    }*/
}