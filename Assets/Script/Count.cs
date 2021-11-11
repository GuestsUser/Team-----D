using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Count : MonoBehaviour
{
    public Text countText; //カウントを表示するテキストを格納
    private int count;
    void Start()
    {
        count = 0;
        SetCountText(); //CountTextの変更
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Coin"))
        {
            other.gameObject.SetActive(false);
            count = count + 1;
            SetCountText();     //CountTextの変更
        }
    }
    void SetCountText()
    {
        countText.text = "" + count.ToString();
    }
}
