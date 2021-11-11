using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveGround3 : MonoBehaviour
{
    //左右キーの入力を取得する変数
    public float horizontal;
    //上下キーの入力を取得する変数
    public float vertical;

    float x;
    float z;

    int up_count;

    int count;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // 左右キーの入力を取得
        horizontal = Input.GetAxis("Horizontal") * -1;
        //上下キーの入力を取得
        vertical = Input.GetAxis("Vertical");

        //if (up_count < 1)
        //{
        //    StartCoroutine("Up");
        //    up_count++;
        //}
        //else
        //{
        //    up_count = 0;
        //}
        if (vertical > 0)
        {
            Up();
        }

    }

    //IEnumerator Up()
    //{
    //    int count=0;
    //    while (vertical>0) {
    //        if (count<=90)
    //        {               
    //            float sin = Mathf.Sin(90 / 90 * count * Mathf.Deg2Rad);
    //            transform.rotation = Quaternion.Euler(sin * 30, 0, 0);

    //        }

    //        count++;
    //        yield return null;
    //    }
    //}
    void Up()
    {

        if (count <= 90)
        {
            float sin = Mathf.Sin(90 / 90 * count * Mathf.Deg2Rad);
            transform.rotation = Quaternion.Euler(sin * 30, 0, 0);
        }
        count++;

    }

    void  
}
