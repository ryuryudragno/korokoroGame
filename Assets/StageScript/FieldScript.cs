using UnityEngine;
using System.Collections;

public class FieldScript : MonoBehaviour
{

    /// <summary>加速度？傾き？</summary>
    private Vector3 acceleration;
    /// <summary>フォント</summary>
    private GUIStyle labelStyle;
    Rigidbody rigidbody;

    public AudioClip dropOutSound;
    AudioSource audioSource;
    float t = 0;

    // Use this for initialization
    void Start()
    {
        //フォント生成
        this.labelStyle = new GUIStyle();
        this.labelStyle.fontSize = Screen.height / 22;
        this.labelStyle.normal.textColor = Color.white;
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        //文字描画はOnGUIでしかできないらしいので保持
        this.acceleration = Input.acceleration;
        transform.Rotate(new Vector3((float)(this.acceleration.y + 0.015), 0, (float)(-this.acceleration.x - 0.005)));//回転する
        //rigidbody.angularVelocity = new Vector3(this.acceleration.y, 0, -this.acceleration.x);
        
    }

    //ボールが落ちた時に呼ばれる関数
    public void ballOut()
    {
        audioSource.PlayOneShot(dropOutSound);
        //rigidbody.AddTorque(new Vector3(0,100,0), ForceMode.Impulse);←回転させたいけどできん泣
        //transform.Rotate(new Vector3(0, 100, 0));
    }

    /// <summary>
    /// GUI更新はここじゃないとダメらしいよ。
    /// まだよくわかんない。
    /// </summary>
    void OnGUI()
    {
        if (acceleration != null)
        {
            float x = Screen.width / 10;
            float y = 0;
            float w = Screen.width * 8 / 10;
            float h = Screen.height / 20;

            for (int i = 0; i < 3; i++)
            {
                y = Screen.height / 10 + h * i;
                string text = string.Empty;

                switch (i)
                {
                    case 0://X
                        text = string.Format("accel-X:{0}", System.Math.Round(this.acceleration.x, 3));
                        break;
                    case 1://Y
                        text = string.Format("accel-Y:{0}", System.Math.Round(this.acceleration.y, 3));
                        break;
                    case 2://Z
                        text = string.Format("accel-Z:{0}", System.Math.Round(this.acceleration.z, 3));
                        break;
                    default:
                        throw new System.InvalidOperationException();
                }

                GUI.Label(new Rect(x, y, w, h), text, this.labelStyle);
            }
        }
    }
}