using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TitleScript : MonoBehaviour
{
    public AudioClip StartSoundEffect;
    AudioSource audioSource;
    //public AudioClip audioClip1;

    // Use this for initialization
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (OnTouchDown())
        {
            Debug.Log("タップされました");
        }
    }

    //スマホ向け そのオブジェクトがタッチされていたらtrue（マルチタップ対応）
    bool OnTouchDown()
    {
        
        // タッチされているとき
        if (0 < Input.touchCount)
        {
            // タッチされている指の数だけ処理
            for (int i = 0; i < Input.touchCount; i++)
            {
                // タッチ情報をコピー
                Touch t = Input.GetTouch(i);
                // タッチしたときかどうか
                if (t.phase == TouchPhase.Began)
                {
                    //SceneManager.LoadScene("Stage1");
                    audioSource.PlayOneShot(StartSoundEffect);
                    StartCoroutine("GoToStageSelect");
                    Debug.Log("あああ");
                    //audioSource.Play();

                    //タッチした位置からRayを飛ばす
                    Ray ray = Camera.main.ScreenPointToRay(t.position);
                    RaycastHit hit = new RaycastHit();
                    if (Physics.Raycast(ray, out hit))
                    {
                        //Rayを飛ばしてあたったオブジェクトが自分自身だったら
                        if (hit.collider.gameObject == this.gameObject)
                        {
                            return true;
                        }
                    }
                }
            }
        }
        return false; //タッチされてなかったらfalse
    }

    IEnumerator GoToStageSelect()
    {
        yield return new WaitForSeconds(1.5f);
        SceneManager.LoadScene("StageSelect");
    }
}
