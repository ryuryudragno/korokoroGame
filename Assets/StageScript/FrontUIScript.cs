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
    public GameObject retryBtn;
    public GameObject panel;
    public AudioClip selectSound;
    public AudioClip gameOverSound;
    AudioSource audioSource;
    public string nextlebel;
    string sceneName;

    /*
    public Button nextBtn;
    public Button selectBtn;
    */

    // Start is called before the first frame update
    void Start()
    {
        panel.SetActive(false);
        nextBtn.SetActive(false);
        selectBtn.SetActive(false);
        titleBtn.SetActive(false);
        retryBtn.SetActive(false);
        audioSource = GetComponent<AudioSource>();
        sceneName = SceneManager.GetActiveScene().name;
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
        panel.SetActive(true);
        nextBtn.SetActive(true);
        selectBtn.SetActive(true);
        titleBtn.SetActive(true);

        /*
        nextBtn.interactable = true;
        selectBtn.interactable = true;
        */
    }
    //ボタン表示
    public void  GameOverAppearButton()
    {
        panel.SetActive(true);
        retryBtn.SetActive(true);
        selectBtn.SetActive(true);
        titleBtn.SetActive(true);

    }
    //タイトル画面へ
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
        StartCoroutine("Restart");
        audioSource.PlayOneShot(selectSound);
    }
    IEnumerator Restart()
    {
        yield return new WaitForSeconds(1.5f);
        SceneManager.LoadScene(sceneName);
    }
    /*次のステージへ*/
    public void MoveToNextStage()
    {
        StartCoroutine("NextStage");
        audioSource.PlayOneShot(selectSound);
    }
    IEnumerator NextStage()
    {
        yield return new WaitForSeconds(1.5f);
        SceneManager.LoadScene(nextlebel);
    }
    public void GameOverSound()
    {
        audioSource.PlayOneShot(gameOverSound);
    }
}
