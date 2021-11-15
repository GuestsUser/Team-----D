using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Effect : MonoBehaviour
{
	//パーティクルを登録する
	public ParticleSystem particle;

	////追いかける対象の位置
	//public Transform Target;

	Vector3 targetpos;

	void Updata()
	{
		targetpos = GameObject.Find("").transform.position;
		GameObject.Find("").transform.position = this.transform.position;
	}

	void LateUpdate()
    {
		if (targetpos)
		{
			//パーティクルを再生する
			particle.Play();
		}
	}
}
