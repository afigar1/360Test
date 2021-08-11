using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class TransitionSpot : MonoBehaviour
{
    private Vector3 lookAtPos;
    public string videoClipName;

    private void Start()
    {
        lookAtPos = Camera.main.transform.position;
    }

    private void Update()
    {
        transform.LookAt(lookAtPos);
    }
    
    public void Clicked()
    {
        //Add any code the transition spot needs to execute in here
    }
}
