using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;

public class LogicaRed : MonoBehaviourPunCallbacks
{
    // Start is called before the first frame update
    void Start()
    {
        PhotonNetwork.ConnectUsingSettings();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public override void OnConnectedToMaster()
    {
       PhotonNetwork.JoinLobby();
    }
    public override void  OnJoinedLobby()
    {
        PhotonNetwork.JoinOrCreateRoom("Cuarto" , new RoomOptions {MaxPlayers = 2}, TypedLobby.Default);
    }
    public override void OnJoinedRoom()
    {
        PhotonNetwork.Instantiate("Personaje", new Vector2(Random.Range(-8,8),4),Quaternion.identity);
    }
}
