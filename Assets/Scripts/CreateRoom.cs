using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CreateRoom : MonoBehaviour
{
    private RoomData rd;
    public InputField roomName;
    public InputField nickName;

    // Start is called before the first frame update
    void Start()
    {
        rd = new RoomData();

    }

    public void Create()
    {
        var manager = KimchiRoomManager.singleton;
        //방 정보 전달
        manager.maxConnections = 2;
        //rd.roomName = roomName.text;
        //rd.p1Name = nickName.text;
        manager.StartHost();
    }

    public void Enter()
    {
        KimchiRoomManager.singleton.StartClient();
    }
}

public class RoomData
{
    public string roomName;
    public string p1Name;
    public string p2Name;
}


