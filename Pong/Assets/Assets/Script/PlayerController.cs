using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	[SerializeField] GameObject leftPaddle;
	[SerializeField] Rigidbody2D leftPaddleRigidBody;

	[SerializeField] GameObject rightPaddle;
	[SerializeField] Rigidbody2D rightPaddleRigidBody;

	[SerializeField] GameObject ball;

	[SerializeField] float moveSpeed;

	private bool ballOnLeftSide;

	// Use this for initialization
	void Start () {

		ballOnLeftSide = true;

	}
	
	// Update is called once per frame
	void Update () {

		// Default speed to 0 if button not pressed

		//rb.velocity = new Vector2 (0f, 0f);

		if (ball.transform.position.x < 0) {
		
			// control left paddle
			ballOnLeftSide = true;
			
		} else {

			// control right paddle
			ballOnLeftSide = false;

		}

		if (Input.GetKey ("up")) {
			//move player up
			MovePaddleUp();

		} else if (Input.GetKey ("down")) {
			//move player down
			MovePaddleDown();

		}
			
	}

	void MovePaddleUp() {

		if (ballOnLeftSide == true) {

			if (leftPaddle.transform.position.y < 4.2) {
				leftPaddleRigidBody.transform.Translate(Vector2.up * Time.deltaTime * moveSpeed);
				// Move the paddle that is active up
			}
		} else {
		
			if (rightPaddle.transform.position.y < 4.2) {
				rightPaddleRigidBody.transform.Translate(Vector2.up * Time.deltaTime * moveSpeed);
				// Move the paddle that is active up
			}

		}

	}

	void MovePaddleDown() {

		if (ballOnLeftSide == true) {

			if (leftPaddle.transform.position.y > -4.2) {
				leftPaddleRigidBody.transform.Translate(Vector2.down * Time.deltaTime * moveSpeed);
				// Move the paddle that is active down
			}
		} else {
		
			if (rightPaddle.transform.position.y > -4.2) {
				rightPaddleRigidBody.transform.Translate(Vector2.down * Time.deltaTime * moveSpeed);
				// Move the paddle that is active down
			}
		
		}

	}
		

}