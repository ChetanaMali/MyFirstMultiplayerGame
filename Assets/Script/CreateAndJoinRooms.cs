using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CreateAndJoinRooms : MonoBehaviourPunCallbacks
{
    [SerializeField] InputField joinIpField;
    [SerializeField] InputField createIpField;
    public void JoinRooms()
    {
        PhotonNetwork.JoinRoom(joinIpField.text);
    }
    public void CreateRoom()
    {
        PhotonNetwork.CreateRoom(createIpField.text);
    }
    public override void OnJoinedRoom()
    {
        PhotonNetwork.LoadLevel("game-scene");
    }
}
