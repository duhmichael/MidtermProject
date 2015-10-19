using UnityEngine;
using System.Collections;

public class RestartButton : MonoBehaviour {


	// Update is called once per frame
	void Update () {
	if (Input.GetKeyDown (KeyCode.R) ) {
			//restart game by reloading current scene
			Application.LoadLevel (Application.loadedLevel) ; 
		}
	}
}
