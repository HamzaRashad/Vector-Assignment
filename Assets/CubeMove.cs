using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMove : MonoBehaviour
{
	Vector3 targetpos,targetpos1,targetpos3,targetpos4;
	float movespeed = 5;
	int temp = 0;

	// Start is called before the first frame update
	void Start()
	{
		targetpos = new Vector3 (3.33f, 0f, 0f);
		targetpos1 = new Vector3 (3.33f, 0f, -3.36f);
		targetpos3 = new Vector3 (-0.2f, 0f, -3.36f);
		targetpos4 = new Vector3 (-0.2f, 0f, 0f);
	}

	// Update is called once per frame
	void Update()
	{
		if (temp == 0) 
		{
			transform.position = Vector3.MoveTowards (transform.position, targetpos, movespeed * Time.deltaTime);
			if (transform.position == targetpos) 
			{
				temp = 1;
			}
			//			
		}

		if (temp == 1) 
		{
			transform.position = Vector3.MoveTowards (transform.position, targetpos1, movespeed * Time.deltaTime);
			if (transform.position == targetpos1) 
			{
				temp = 2;
			}
		}
		//
		if (temp == 2) 
		{
			transform.position = Vector3.MoveTowards (transform.position, targetpos3, movespeed * Time.deltaTime);
			if (transform.position == targetpos3) 
			{
				temp = 3;
			}
		}
		//
		if (temp == 3) 
		{
			transform.position = Vector3.MoveTowards (transform.position, targetpos4, movespeed * Time.deltaTime);
			if (transform.position == targetpos4) 
			{
				temp = 4;
			}

		}
	}
}
