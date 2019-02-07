using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Oscill : MonoBehaviour {

	float timeCount = 0;
	bool dir = false;

	float speed;
	float width;
	float height;

	// Use this for initialization
	void Start () {

		speed = 3;
		width = 4;
		height = 4;
		
	}
	
	// Update is called once per frame
	void Update () {


		if(Input.GetKeyDown(KeyCode.LeftArrow))
		{
			dir = false;

		}
		if(Input.GetKeyDown(KeyCode.RightArrow))
		{
			dir = true;

		}

		if(dir)
		timeCount += Time.deltaTime * speed;
		else
		timeCount -= Time.deltaTime * speed;


		float x = Mathf.Cos (timeCount)*width;
		float y = Mathf.Sin (timeCount)*height;
		float z = 0;

		transform.position = new Vector3(x,y,z);

		var pos = transform.position;

		pos.y = pos.y + 12f;
		transform.position = pos;
		
	}
}
