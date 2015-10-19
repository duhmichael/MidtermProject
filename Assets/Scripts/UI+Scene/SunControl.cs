using UnityEngine;
using System.Collections;

public class SunControl : MonoBehaviour {

	//put this on directional light
	
	// Update is called once per frame
	void Update () {
		if (IntroMenuStart.useNightmareMode) {
		GetComponent<Light>().intensity = 0.0f;
		}else {
			GetComponent<Light>().intensity = 1.0f;
		}
	}
}
