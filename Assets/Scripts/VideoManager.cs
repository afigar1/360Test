using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class VideoManager : MonoBehaviour
{
    [SerializeField] private VideoPlayer _videoPlayer;
    [SerializeField] private string _defaultVideoClip;
    void Awake()
    {
        _videoPlayer.url = _defaultVideoClip;
        _videoPlayer.Play();
    }

    public void Transition(TransitionSpot t)
    {
        _videoPlayer.url = t.videoUrl;
        t.gameObject.SetActive(false);
    }
}
