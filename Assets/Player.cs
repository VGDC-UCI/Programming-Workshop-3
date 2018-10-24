using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

	// We need a variable to access our Rigidbody, 
	// which is what we'll be manipuating
	Rigidbody2D rb;
	public float speed;
	Vector2 velocity = new Vector2(0, 0);

	// Use this for initialization
	void Start () {
		// Get our object's Rigidbody component and store it in rb
		rb = GetComponent<Rigidbody2D>();
	}

	void Update () {
		// Do input checking here

	}
	
	void FixedUpdate () {
		// Do physics operations here
		// Remember to use Time.fixedDeltaTime instead of Time.deltaTime

	}

	void OnTriggerEnter2D (Collider2D other) {
		// Will call when player enters a trigger
		// The triggers tag can be accessed with
		// other.tag
	}
}
