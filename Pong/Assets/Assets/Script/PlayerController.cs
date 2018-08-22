using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	[SerializeField]
	GameObject leftPaddle;
	[SerializeField]
	GameObject rightPaddle;
	[SerializeField]
	Collider2D detectBallCollider;

	public float moveSpeed;

	[SerializeField]
	Rigidbody2D leftPaddleRigidBody;
	[SerializeField]
	Rigidbody2D rightPaddleRigidBody;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {

		// Default speed to 0 if button not pressed

		//rb.velocity = new Vector2 (0f, 0f);

		if (Input.GetKey ("up")) {
			//move player up
			MovePaddleUp();

		} else if (Input.GetKey ("down")) {
			//move player down
			MovePaddleDown();
		}
			
	}

	void MovePaddleUp() {

		if (transform.position.y < 4.2) {
			//rb.GetComponent<Rigidbody2D> ().velocity = new Vector2 (0f, moveSpeed);
			// Move the paddle that is active up
		}

	}

	void MovePaddleDown() {

		if (transform.position.y > -4.2) {
			//rb.GetComponent<Rigidbody2D> ().velocity = new Vector2 (0f, moveSpeed * -1);
			// Move the paddle that is active down
		}

	}
		
	void OnTriggerStay2D(Collider2D other) {
	
		print ("test");
		// Toggle active paddle

	}

}