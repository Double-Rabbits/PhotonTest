using UnityEngine;

public class StartUpCreateRoom : Photon.MonoBehaviour
{
    private PhotonView myPhotonView;

    // Use this for initialization
    void Start()
    {
		if(PhotonNetwork.connected){
			return;
		}

		Debug.Log("StartUpCreateRoom: Connect");
        PhotonNetwork.ConnectUsingSettings("0.1");
    }

    void OnJoinedLobby()
    {
		PhotonNetwork.CreateRoom("StartUpRoom", new RoomOptions() { maxPlayers = 6 }, null);
    }

	public void OnCreatedRoom()
	{
		Debug.Log("OnCreatedRoom: " + PhotonNetwork.room.name);
	}

	public void OnJoinedRoom()
	{
		Debug.Log("OnJoinedRoom: " + PhotonNetwork.room.name);

	}
}
