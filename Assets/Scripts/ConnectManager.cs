using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Photon.Pun;
using Photon.Realtime;
public class ConnectManager : MonoBehaviourPunCallbacks
{
    public InputField createInput;
    public InputField joinInput;

    public void CreateRoom() 
    {
        RoomOptions roomOptins = new RoomOptions();
        roomOptins.MaxPlayers = 4;
        PhotonNetwork.CreateRoom(createInput.text, roomOptins);
    }

    public void JoinRoom() 
    {
        PhotonNetwork.JoinRoom(joinInput.text);
    }

    public override void OnJoinedRoom() 
    {
        PhotonNetwork.LoadLevel(1);
    }

}
