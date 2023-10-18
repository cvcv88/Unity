using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Forever_MoveV : MonoBehaviour
{
	// Start is called before the first frame update
	void Start()
	{
		//this.transform.Translate(0, 5, 0);
	}

	public float speed = 5;

	void FixedUpdate()
	{
		this.transform.Translate(0, speed / (float)50.0, 0);
		//this.transform.Translate(0, 5.0/50.0, 0);
		//this.transform.Translate(0, (float)0.1, 0); cannot convert double to float
	}
}
