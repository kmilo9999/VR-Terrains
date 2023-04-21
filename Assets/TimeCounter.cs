using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.UI;
using Photon.Pun;
using System;

public class TimeCounter : MonoBehaviourPun
{
    // Start is called before the first frame update
    [SerializeField] TextMeshProUGUI UiText;
    [SerializeField] Button countingButton;
    [SerializeField] GameObject waterCouner;
    private float timeValue = 0.0f;
    public bool startCounting = false;
    private TimeSpan timePlaying;

    // Update is called once per frame
    void Update()
    {
        

        if (startCounting)
        {
            UiText.gameObject.SetActive(true);
            countingButton.gameObject.SetActive(false);
            timeValue += Time.deltaTime;
            timePlaying = TimeSpan.FromSeconds(timeValue);
        }

        float minutes = Mathf.FloorToInt(timeValue/ 60);
        float seconds = Mathf.FloorToInt(timeValue % 60);
        string timeStr = string.Format("{0:00}:{0:00}", minutes, seconds);
        Debug.Log(timeStr[2]);
        Debug.Log(timeStr[3]);

        UiText.text = timePlaying.ToString("mm':'ss'.'ff");
    }

    public void StartCounter()
    {
      
        photonView.RPC("StartNetworkCounter", RpcTarget.All, "jup", "and jup.");
    }

    [PunRPC]
    void StartNetworkCounter(string a, string b, PhotonMessageInfo info)
    {
        startCounting = true;

    }
}
