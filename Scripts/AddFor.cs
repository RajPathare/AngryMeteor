using UnityEngine;

public class AddFor : MonoBehaviour {


	// Use this for initialization
	void Start () {

		
	}
	
	// Update is called once per frame
	void Update () {



		var pos = transform.position;

		pos.y = pos.y + 0.03f;
		transform.position = pos;

		
	}
}
