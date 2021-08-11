using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class VideoManager : MonoBehaviour
{
    [SerializeField] private VideoPlayer _videoPlayer;

    [SerializeField] private string _defaultVideoClipName;
    //[SerializeField] private VideoClip _defaultVideoClip;

    void Awake()
    {
        _videoPlayer.url = System.IO.Path.Combine(Application.streamingAssetsPath, _defaultVideoClipName+".mp4");
        _videoPlayer.enabled = false;
    }

    public void StartVideoPlayer()
    {
        _videoPlayer.enabled = true;
    }

    public void Transition(TransitionSpot t)
    {
        _videoPlayer.url = System.IO.Path.Combine(Application.streamingAssetsPath, t.videoClipName+".mp4");
        t.gameObject.SetActive(false);
    }
}
