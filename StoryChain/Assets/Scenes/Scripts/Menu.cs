using UnityEngine;
using Photon.Pun;

public class Menu : MonoBehaviourPunCallbacks
{
    public void CreateRoom()
    {
        string roomName = Random.Range(100000, 999999).ToString();
        PhotonNetwork.CreateRoom(roomName);
    }

    public override void OnCreatedRoom()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Setup");
    }
}
