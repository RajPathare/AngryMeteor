using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class UIPresserL : MonoBehaviour , IPointerDownHandler, IPointerUpHandler {

	bool pressed = false;
	public Transform shield;
	public float speed = 3f;


	public void OnPointerDown(PointerEventData eventData){

		pressed = true;
	}

	public void OnPointerUp(PointerEventData eventData){

		pressed = false;

	}


	void Update () {


		if(pressed)
		{
			rotatee ();

		}


	}

	public void rotatee(){

		shield.Rotate(0f , 0f , speed);
	}
}
