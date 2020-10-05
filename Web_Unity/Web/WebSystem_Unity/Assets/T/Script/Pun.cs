using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;

public class Pun : MonoBehaviourPunCallbacks
{
    // Start is called before the first frame update
    void Start()
    {
        
    }


    private void OnGUI()
    {
        //ログイン状態を画面上に出力
        GUILayout.Label(PhotonNetwork.NetworkClientState.ToString());
    }

    //ルームに入る前に呼び出される
    public override void OnConnectedToMaster()
    {
        PhotonNetwork.JoinOrCreateRoom("room", new RoomOptions(), TypedLobby.Default);
    }

    //ルームに入った後に呼び出される
    public override void OnJoinedRoom()
    {
        GameObject player = PhotonNetwork.Instantiate("Human", new Vector3(0,5,0), Quaternion.identity, 0);

        Player playerScript = player.GetComponent<Player>();
        playerScript.enabled = true;

    }



}
