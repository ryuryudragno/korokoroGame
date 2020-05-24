using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TitleScript : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

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
                    SceneManager.LoadScene("Stage1");
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
}
