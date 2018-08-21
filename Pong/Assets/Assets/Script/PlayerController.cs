using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	public float moveSpeed;

	Rigidbody2D rb;

	// Use this for initialization
	void Start () {
		rb = gameObject.GetComponent<Rigidbody2D>();

	}
	
	// Update is called once per frame
	void Update () {

		// Default speed to 0 if button not pressed

		rb.velocity = new Vector2 (0f, 0f);

		if (Input.GetKey ("up")) {
			//move player up
			if (transform.position.y < 4.2) {
				rb.GetComponent<Rigidbody2D> ().velocity = new Vector2 (0f, moveSpeed);
			}

		} else if (Input.GetKey ("down")) {
			//move player down
			if (transform.position.y > -4.2) {
				rb.GetComponent<Rigidbody2D> ().velocity = new Vector2 (0f, moveSpeed * -1);
			}
		}

	}
}