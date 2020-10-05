using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;
using System.Diagnostics;

public class Pun : MonoBehaviourPunCallbacks
{
    // Start is called before the first frame update
    void Start()
    {
        Connect();
    }
    public void Connect()
    {
        // we check if we are connected or not, we join if we are , else we initiate the connection to the server.
        if (PhotonNetwork.IsConnected)
        {
            // #Critical we need at this point to attempt joining a Random Room. If it fails, we'll get notified in OnJoinRandomFailed() and we'll create one.
            PhotonNetwork.JoinRandomRoom();
        }
        else
        {
            // #Critical, we must first and foremost connect to Photon Online Server.
            PhotonNetwork.ConnectUsingSettings();
            PhotonNetwork.GameVersion = "1";
            UnityEngine.Debug.Log("d");
        }
    }

    private void OnGUI()
    {
        //ログイン状態を画面上に出力
        //GUILayout.Label(PhotonNetwork.NetworkClientState.ToString());
        
    }

    //ルームに入る前に呼び出される
    public override void OnConnectedToMaster()
    {
        PhotonNetwork.JoinOrCreateRoom("room", new RoomOptions(), TypedLobby.Default);
        
    }

    //ルームに入った後に呼び出される
    public override void OnJoinedRoom()
    {
        GameObject player = PhotonNetwork.Instantiate("Player", new Vector3(0,5,0), Quaternion.identity, 0);

        Player playerScript = player.GetComponent<Player>();

        playerScript.enabled = true;
        player.SetActive(true);

    }



}
