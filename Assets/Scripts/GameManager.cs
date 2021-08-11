using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public VideoManager videoManager;
    public GameObject menu;

    private void Awake()
    {
        menu.SetActive(true);
    }


    public void StartGame()
    {
        videoManager.StartVideoPlayer();
        menu.SetActive(false);
    }
}
