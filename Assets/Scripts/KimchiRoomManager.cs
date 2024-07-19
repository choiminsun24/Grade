using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mirror;

public class KimchiRoomManager : NetworkRoomManager
{

    public void GoGame()
    {
        KimchiRoomManager.singleton.ServerChangeScene(GameplayScene);
    }

}
