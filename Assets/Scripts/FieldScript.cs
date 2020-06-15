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
    int maxAngle = 20;
    int minAngle = -20;
    float xRotate = 0;
    float yRotate = 0;
    float zRotate = 0;

    Vector3 dropForce = new Vector3(0.0f,0.0f,1.0f);


    // Use this for initialization
    void Start()
    {
        //フォント生成
        this.labelStyle = new GUIStyle();
        this.labelStyle.fontSize = Screen.height / 22;
        this.labelStyle.normal.textColor = Color.white;
        audioSource = GetComponent<AudioSource>();
        rigidbody = this.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Mathf.Approximately(Time.timeScale, 0f))
        {
            return;
        }
        //文字描画はOnGUIでしかできないらしいので保持
        this.acceleration = Input.acceleration;
        //transform.Rotate(new Vector3((float)(this.acceleration.y + 0.015), 0, (float)(-this.acceleration.x - 0.005)));//回転する
        //Debug.Log(new Vector2(xRotate,zRotate));
        transform.eulerAngles = new Vector3(xRotate, yRotate, zRotate);
        xRotate = Mathf.Clamp(xRotate + (float)(this.acceleration.y + 0.015), minAngle, maxAngle);
        zRotate = Mathf.Clamp(zRotate + (float)(-this.acceleration.x - 0.005), minAngle, maxAngle);


        /*
        if(transform.rotation.x >= 20 || transform.rotation.x <= -20)
        {
            this.acceleration.y = (float)-0.015;
        }*/

        //rigidbody.angularVelocity = new Vector3(this.acceleration.y, 0, -this.acceleration.x);

    }

    //ボールが落ちた時に呼ばれる関数
    public void ballOut()
    {
        audioSource.PlayOneShot(dropOutSound);

        rigidbody.AddTorque(Vector3.up * 10000, ForceMode.Impulse);//←回転させたいけどできん泣
        //Debug.Log("読んだ？");

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

                //GUI.Label(new Rect(x, y, w, h), text, this.labelStyle);
            }
        }
    }
}