using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;
using TMPro;

public class NetworkManager : MonoBehaviourPunCallbacks
{

    [SerializeField] GameObject[] joinRoomUI;
    [SerializeField] GameObject conectServerButton;
    [SerializeField] string level_to_load;
    [SerializeField] string[] roomLabel;

    private bool isConnected = false;
    public void ConnectedToServer()
    {
        if (!isConnected)
        {
            PhotonNetwork.ConnectUsingSettings();
        }
        
    }

    public override void OnConnectedToMaster()
    {
        base.OnConnectedToMaster();
        conectServerButton.SetActive(false);
        isConnected = true;
        PhotonNetwork.JoinLobby();
    }

    public override void OnJoinedLobby()
    {
        base.OnJoinedLobby();
        for (int i = 0; i < joinRoomUI.Length; i++)
        {
            joinRoomUI[i].SetActive(true);
        }
        
    }

    public void InitializeRoom(int room)
    {
        RoomOptions roomOptions = new RoomOptions();
        roomOptions.MaxPlayers = 4;
        roomOptions.IsVisible = true;
        roomOptions.IsOpen = true;

        string roomName = "CS1951t_"+room.ToString();
        PhotonNetwork.JoinOrCreateRoom(roomName, roomOptions, TypedLobby.Default);
    }

    public override void OnJoinedRoom()
    {
        base.OnJoinedRoom();
        PhotonNetwork.LoadLevel(level_to_load);
    }

    public override void OnPlayerEnteredRoom(Player newPlayer)
    {
        base.OnPlayerEnteredRoom(newPlayer);
    }
}
