using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnCollision_CountAndHide : MonoBehaviour
{
	public string targetObjectName;
	public int addValue;

	void OnCollisionEnter2D(Collision2D collision)
	{
		if(collision.gameObject.name == targetObjectName)
		{
			GameCounter.value = GameCounter.value + addValue;
			this.gameObject.SetActive(false);
		}
	}
}
