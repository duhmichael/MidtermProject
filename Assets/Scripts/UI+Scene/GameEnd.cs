using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameEnd : MonoBehaviour {
	
	public Text textUI;
	
	// Use this for initialization
	void Start () {
		
	}
	
	//whatever code is here: will get fired when something enters the trigger
	//OR, if you put this on the player, it will fire when the player enters a trigger
	void OnTriggerEnter (Collider end) { //this paramter will get automatically filled in with the activator
		
		textUI.text ="You've bearly made it home...";
		
	}
	

	
}
