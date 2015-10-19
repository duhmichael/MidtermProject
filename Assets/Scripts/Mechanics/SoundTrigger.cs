using UnityEngine;
using System.Collections;

public class SoundTrigger : MonoBehaviour {

	public AudioSource mySound; //assign in inspector


	
	// Update is called once per frame
	void Update () {
	if (Input.GetKeyDown (KeyCode.W)) {
			mySound.Play ();
		}
	}

}




//check to make sure robert uploaded additions for
//constant walking sounds


