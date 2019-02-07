using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircMotion : MonoBehaviour {


	public float speed = 3f;

	void Start () {

    }
   
	
	void FixedUpdate () {

		if(Input.GetKey("a"))
		{
			transform.Rotate( 0f, 0f, speed);
		}
		if(Input.GetKey("d"))
		{

			transform.Rotate( 0f, 0f, -speed);
		}
        
    }
}
