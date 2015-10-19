using UnityEngine;
using System.Collections;

public class LightFlicker : MonoBehaviour {


	public Light flickeryLight; //assign in inspector
	public float LowFlicker = 0f;
	public float HighFlicker = 8f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		flickeryLight.intensity = Random.Range (LowFlicker, HighFlicker);
	}
}
