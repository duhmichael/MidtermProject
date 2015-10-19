using UnityEngine;
using System.Collections;

public class UpAndDown : MonoBehaviour {
	
	//last point in time when I changed direction
	public float timeDuration = 3f;
	public float moveSpeed = 0.08f;
	
	float lastTime;
	
	
	bool moveForward = false; 
	
	// Update is called once per frame
	void Update () {
		//movement code
		if (moveForward) {
			transform.Translate (-moveSpeed * Time.deltaTime, 0f, 0f);
		} else {
			transform.Translate (-moveSpeed * Time.deltaTime, 0f, 0f);
		}
		
		//which way should we move?
		Debug.Log ( Time.time - lastTime );
		if ( Time.time - lastTime > timeDuration ) {
			moveForward = !moveForward; //! is 'not', this is called a ''toggle''
			lastTime = Time.time; 
			transform.Rotate (0f, 180f, 0f);
			//rotate 180 degrees-- transform.rotate stuff plz
		}
	}
}
