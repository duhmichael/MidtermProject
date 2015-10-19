using UnityEngine;
using System.Collections;

public class Restart : MonoBehaviour {

	Vector3 startPos;

	// Use this for initialization
	void Start () {
	//set a starting position

		startPos = transform.position;

	}
	
	// Update is called once per frame
	void Update () {
	//press a button to return to starting position
		if ( Input.GetKey (KeyCode.Space)){
			transform.position = startPos;
		}


		//load a diff level
		//Application.LoadLevel (2); //3rd item in the build list

	}
}



//BUGS THAT NEED FIXING
//make sure you are able to respawn after death
//respawning doesn't fix weird corner-collision auto movement