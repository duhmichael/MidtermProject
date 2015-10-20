using UnityEngine;
using System.Collections;

public class IntroMenuStart : MonoBehaviour {

	//use the "static" keyword to make something
	//persist in code instead of a scene
	public static bool useNightmareMode = false;

	void Start() {
		useNightmareMode = false; //reset manually
	}


	// Update is called once per frame
	void Update () {
		//if player presses space
		if ( Input.GetKeyDown (KeyCode.W) ) {
			//then change to the actual 'game' scene
			//can use the name of the level or the number assigned in the Build Settings
			Application.LoadLevel( 1 ) ;
			//Application.LoadLevel( "myGameScene");
		}



		//if (Input.AnyKeyDown) is also a thing

		//if ( Input.GetKey (KeyCode.A) && Input.GetKey (KeyCode.S) &&/// etc etc for all the buttons you want pressed
		//AT THE SAME TIME


		if (Input.GetKeyDown (KeyCode.N) ) {
			useNightmareMode = true; 
	}
}
}
