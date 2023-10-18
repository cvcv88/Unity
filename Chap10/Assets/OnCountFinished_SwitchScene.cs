using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OnCountFinished_SwitchScene : MonoBehaviour
{
	public int lastCount = 3;
	public string sceneName = "";

	void FixedUpdate()
	{
		if(GameCounter.value == lastCount)
		{
			SceneManager.LoadScene(sceneName);
		}
	}
}
