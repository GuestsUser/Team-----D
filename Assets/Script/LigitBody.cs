using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LigitBody : MonoBehaviour
{

    [SerializeField] private float mass;
    [SerializeField] private bool usegravity;
    [SerializeField] private bool iskinematic;

    [HideInInspector] public Vector3 force;//掛かってる力


    void Start()
    {
        
    }

    void FixedUpdate()
    {
        force += Physics.gravity * Time.deltaTime;//プロパティの重力は力の値にどう加えるのが正しいかTestに新しいシーンを作ってテストしてみたい
        transform.position+=force * Time.deltaTime;
        //衝突判定から
    }
}
