﻿using UnityEngine;
using System.Collections;

public class autoDeleteOutOFScreen : MonoBehaviour
{
    public Camera _setCamera;

    //Margin
    float margin = 2.0f; //マージン(画面外に出てどれくらい離れたら消えるか)を指定
    float negativeMargin;
    float positiveMargin;

    void Start()
    {
        if (_setCamera == null)
        {
            _setCamera = Camera.main;
        }

        negativeMargin = 0 - margin;
        positiveMargin = 1 + margin;
    }

    // Update is called once per frame
    void Update()
    {
        if (this.isOutOfScreen())
        {
            Destroy(gameObject);
        }
    }

    bool isOutOfScreen()
    {
        Vector3 positionInScreen = _setCamera.WorldToViewportPoint(transform.position);
        positionInScreen.z = transform.position.z;

        if (positionInScreen.x <= negativeMargin ||
            positionInScreen.x >= positiveMargin ||
            positionInScreen.y <= negativeMargin ||
            positionInScreen.y >= positiveMargin)
        {
            return true;
        }
        else {
            return false;
        }
    }
}