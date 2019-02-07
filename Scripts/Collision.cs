using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour {



	public GameObject met;

	// Use this for initialization
	void Start () {




	}
	
	// Update is called once per frame
	void Update () {
		
	}


	void OnCollisionEnter2D (Collision2D other) {

		if(other.gameObject.tag == "mainStar"){

			Debug.Log ("GameOver");

			//Destroy (this.gameObject);

		}

		if(other.gameObject.tag == "shld") {

			met.SetActive (false);
			//met.SetActive (true);

			Invoke ("Activate" , 5f);

		}

	}

	void Activate() {

		met.SetActive (true);

	}



}
