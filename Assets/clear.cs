﻿using UnityEngine;
using UnityEngine.UI; // 追加

class clear : MonoBehaviour
{
    public Text gameClearMessage; // 追加
    Transform myTransform;

    void Start()
    {
        myTransform = transform;
    }

    void Update()
    {
        if (myTransform.childCount == 0)
        {
            gameClearMessage.text = "Game Clear"; // 追加
            Time.timeScale = 0f;
        }
    }
}