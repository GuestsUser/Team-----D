using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Count : MonoBehaviour
{
    public Text countText;
    private int count;
    private int CoinNum;
    void Start()
    {
        count = 0;
        CoinNum = GameObject.Find("Coin").transform.childCount;
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Coin"))
        {
            other.gameObject.SetActive(false);
            count = count + 1;
        }
    }
}
