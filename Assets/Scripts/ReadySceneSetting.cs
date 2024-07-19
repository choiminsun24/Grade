using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Mirror;

public class ReadySceneSetting : NetworkRoomManager
{
    public Sprite[] imgs;
    public Image profileImage;

    private int imageNum;

    void Start()
    {
        imageNum = Random.Range(0, imgs.Length);
        ImageUpdate();
    }

    public void ImageCountUp()
    {
        imageNum++;

        if (imageNum >= imgs.Length)
            imageNum = 0;

        ImageUpdate();
    }

    public void ImageCountDown()
    {
        imageNum--;

        if (imageNum < 0)
            imageNum = imgs.Length-1;

        ImageUpdate();
    }

    void ImageUpdate()
    {
        profileImage.sprite = imgs[imageNum];
    }

    public void ExitReadyRoom()
    {
        var manager = KimchiRoomManager.singleton;

        if(manager.mode == Mirror.NetworkManagerMode.Host)
        {
            manager.StopHost();
        }else if (manager.mode == Mirror.NetworkManagerMode.ClientOnly)
        {
            manager.StopClient();
        }
    }

    public void StartGame()
    {
        KimchiRoomManager.singleton.ServerChangeScene(GameplayScene);
    }
}
