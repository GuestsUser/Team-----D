using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

[ExecuteInEditMode] [SaveDuringPlay] [AddComponentMenu("")] // Hide in menu
public class CameraLockY : CinemachineExtension
{
    [Tooltip("カメラのY座標を固定する値")]
    public float m_YPosition = 10;

    [Tooltip("カメラの回転を固定する値")]
    public float m_RotePosition;

    protected override void PostPipelineStageCallback(
        CinemachineVirtualCameraBase vcam,
        CinemachineCore.Stage stage, ref CameraState state, float deltaTime)
    {
        if(stage == CinemachineCore.Stage.Body)
        {
            var pos = state.RawPosition;
            pos.y = m_YPosition;
            state.RawPosition = pos;
        }
    }

    void Update()
    {
        this.transform.rotation = Quaternion.Euler(0, 0, 0);
    }
}
