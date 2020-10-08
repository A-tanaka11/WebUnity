using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;
using System.Diagnostics;
using System.ComponentModel.Design.Serialization;

public class Pun1 : MonoBehaviourPunCallbacks
{
    [SerializeField]
    private GameObject camera;

    // Start is called before the first frame update
    void Start()
    {
        PhotonNetwork.ConnectUsingSettings();
        //PhotonNetwork.JoinLobby();
        //Connect();
    }
    public void Connect()
    {
        //つながってる？
        if (PhotonNetwork.IsConnected)
        {
            
            PhotonNetwork.CreateRoom("room");
            UnityEngine.Debug.Log("room作成");
        }
        else
        {
            
            PhotonNetwork.ConnectUsingSettings();
            PhotonNetwork.GameVersion = "1";
            UnityEngine.Debug.Log("d");
        }
    }

    public override void OnJoinedLobby()
    {
        UnityEngine.Debug.Log("ロビーに入る");
    }

    //private void OnGUI()
    //{
    //    //ログイン状態を画面上に出力
    //    //GUILayout.Label(PhotonNetwork.NetworkClientState.ToString());

    //}

    //ルームに入る前に呼び出される
    public override void OnConnectedToMaster()
    {
        PhotonNetwork.JoinOrCreateRoom("room", new RoomOptions(), TypedLobby.Default);
        UnityEngine.Debug.Log("room作成2");

    }

    //ルームに入った後に呼び出される
    public override void OnJoinedRoom()
    {

        GameObject player = PhotonNetwork.Instantiate("Player", new Vector3(0, 5, 0), Quaternion.identity, 0);
        player.SetActive(true);
        Player playerScript = player.GetComponent<Player>();
        playerScript.enabled = true;
        camera.transform.parent = player.transform;
        camera.transform.position = player.transform.position;

    }



}
