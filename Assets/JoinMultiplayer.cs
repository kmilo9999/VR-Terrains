using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;
using TMPro;

public class JoinMultiplayer : MonoBehaviourPunCallbacks
{
    // Start is called before the first frame update
    [SerializeField] TextMeshProUGUI m_Object;
    [SerializeField] string level_to_load;
    private string createRoomStr ="";

    public void CreateOrJoinRoomCS1951t()
    {

        //PhotonNetwork.ConnectUsingSettings();
       
    }

    public override void OnConnectedToMaster()
    {
        //base.OnConnectedToMaster();
        //RoomOptions roomOptions = new RoomOptions();
        //roomOptions.MaxPlayers = 10;
        //roomOptions.IsVisible = true;
        //roomOptions.IsOpen = true;

        //PhotonNetwork.JoinOrCreateRoom("CS1951t", roomOptions, TypedLobby.Default);
    }

    public override void OnCreatedRoom()
    {
        createRoomStr = "Creating and ";
        //m_Object.text = "Creating and Joined a Room";
        //MasterManager.DebugConsole.AddText("Room created",this );
        //PhotonNetwork.LoadLevel(level_to_load);
    }

    public override void OnCreateRoomFailed(short returnCode, string message)
    {
        m_Object.text =  "Room creation failed";
        //MasterManager.DebugConsole.AddText("Room creatinf failed "+message,this);
    }

    public override void OnJoinedRoom()
    {
       // m_Object.text = createRoomStr +  "Joined a Room";
        //PhotonNetwork.LoadLevel(level_to_load);
    }


    public override void OnPlayerEnteredRoom(Player newPLayer)
    {
        Debug.Log("A new player Joined the Room");
    }
}
