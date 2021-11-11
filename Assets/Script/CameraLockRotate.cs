using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraLockRotate : MonoBehaviour
{
    Quaternion rot;

    void Start()
    {
        rot = this.transform.rotation;
    }

    void LateUpdate()
    {
        this.transform.rotation = rot;
    }
}
