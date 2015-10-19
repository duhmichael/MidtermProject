using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

	public static GameManager instance; //code refers to itself, anyone can talk to this object easily 
	public int currentScore = 0;


	// Use this for initialization
	void Start () {
		instance = this; 

		if ( IntroMenuStart.useNightmareMode ) {
			Debug.Log ("nightmare mode activated! happy halloween");
		}
	}
	
	// Update is called once per frame
	void Update () {
	
		if ( IntroMenuStart.useNightmareMode ) {
			transform.Rotate (0f, 90f * Time.deltaTime, 0f); //rotate the cube, spoopy*~*~
		}

		if (Input.GetKeyDown (KeyCode.Space) ) {
			currentScore++; //you get points
		}
	}
}
