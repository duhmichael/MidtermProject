using UnityEngine;
using System.Collections;

public class BasicPlayerMovement : MonoBehaviour {
	
	public float moveSpeed = 5f;
	Rigidbody rbody;
	Vector3 inputVector; // remembers what direction I want to go in, based on input
	
	Vector3 moveVector;
	
	void Start () {
		rbody = GetComponent<Rigidbody>(); // remember shortcut to access rigidbody
	}
	// Update is when input / graphics run
	void Update () {

		moveVector = new Vector3( Input.GetAxis ("Horizontal"), 0f, Input.GetAxis ("Vertical") );
		Debug.Log ( moveVector.ToString () );

	}

	// FixedUpdate is when physics runs
	void FixedUpdate () {
		float yVelocity = GetComponent<Rigidbody>().velocity.y;
		GetComponent<Rigidbody>().velocity = moveVector * 5f + Vector3.up * yVelocity;
	}
	
}