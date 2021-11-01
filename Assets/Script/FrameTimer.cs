﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FrameTimer : MonoBehaviour
{
    float countTime = 0;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // countTimeに、ゲームが開始してからの秒数を格納
        countTime += Time.deltaTime;

        // 小数2桁にして表示
        GetComponent<Text>().text = countTime.ToString("F2");
    }
}
