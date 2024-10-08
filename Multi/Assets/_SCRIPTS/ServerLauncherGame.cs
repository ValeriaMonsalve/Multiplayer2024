using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
public class ServerLauncherGame : MonoBehaviourPunCallbacks
{

    public PhotonView Player;
    public Transform spawm;

    void Start()
    {
       //conexión al servidor
       
        PhotonNetwork. ConnectUsingSettings();
    }


    public override void OnConnectedToMaster() //conectar a sala
    {
        Debug.Log("Nos hemos conectado al master");

        PhotonNetwork.JoinRandomOrCreateRoom(); //crea sala si no existe
    }

    public override void OnJoinedRoom()
    {
        PhotonNetwork.Instantiate (Player.name, spawn.position, spawm.rotation);
    }

}
