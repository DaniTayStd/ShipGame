using UnityEngine;
using System.Collections;

public class MotorScript : MonoBehaviour {

	public float speed = 14.0f;

	// Use this for initialization
	void Start () {
	
		// HELLO I AM MAKING SOME CHANGES RIGHT NOW
		//
		//
		//
		//
		//
	}
	
	// Update is called once per frame
	void Update () {
	

	}

	void FixedUpdate() {

		transform.Translate(0,0,speed *Time.deltaTime);
	}
}
