using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class ConnectToServer : MonoBehaviourPunCallbacks
{
    // Start is called before the first frame update
    public GameObject UIPlane;

    void Start()
    {
        //PhotonNetwork.ConnectUsingSettings();
    }

    public override void OnConnectedToMaster()
    {
        //Debug.Log("Connected to server");
        //PhotonNetwork.JoinLobby();
    }

    public override void OnJoinedLobby()
    {
        //UIPlane.SetActive(true);
    }
}
