using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;

public class AdvertiseScript : MonoBehaviour
{
    public void Start()
    {
        Advertisement.Initialize("3667968", false);
    }
    //広告呼び出し
    public void ShowRewardedAd()
    {
        Debug.Log("あ");
        Debug.Log("isSupported:" + Advertisement.isSupported);
        Debug.Log("isInitialized:" + Advertisement.isInitialized);
        if (Advertisement.IsReady())
        {
            StartCoroutine("Advertise");
            Debug.Log("い");
        }
    }

    IEnumerator Advertise()
    {
        yield return new WaitForSeconds(3.5f);
        Advertisement.Show();
    }
}
