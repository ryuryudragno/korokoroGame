using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;

public class AdvertiseScript : MonoBehaviour
{
    const string advertiseId = "3667968";

    public void Start()
    {
        Advertisement.Initialize(advertiseId, false);
    }
    //広告呼び出し
    public void ShowRewardedAd()
    {
        Debug.Log("あ");
        Debug.Log("isSupported:" + Advertisement.isSupported);
        Debug.Log("isInitialized:" + Advertisement.isInitialized);
        if (Advertisement.IsReady())
        {
            StartCoroutine(Advertise());//コルーチンの引数は関数使える
            Debug.Log("い");
        }
    }

    IEnumerator Advertise()
    {
        yield return new WaitForSeconds(3.5f);
        Advertisement.Show();
    }
}
