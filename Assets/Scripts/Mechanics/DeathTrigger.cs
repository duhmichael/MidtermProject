using UnityEngine;
using System.Collections;

public class DeathTrigger : MonoBehaviour {

	public AudioSource mySound; //assign in inspector

	// Use this for initialization
	void Start () {
		
	}
	
	//whatever code is here: will get fired when something enters the trigger
	//OR, if you put this on the player, it will fire when the player enters a trigger
	void OnTriggerEnter (Collider activator) { //this paramter will get automatically filled in with the activator
		
		Destroy (activator.gameObject);
		mySound.Play(); //play sound upon entering trigger
		
	}

//	void OnTriggerEnter() {
//
//	}

}
