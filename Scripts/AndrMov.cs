using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AndrMov : MonoBehaviour {

	public float speed = 3f;
	public Transform shield;

	// Use this for initialization
	void Start () {
		
	}
	

	public void rotateShield() {


		Debug.Log ("hmm");
		shield.Rotate(0f , 0f , speed);

	
	}


		



}
