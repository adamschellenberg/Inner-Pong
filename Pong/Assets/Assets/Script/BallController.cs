using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BallController : MonoBehaviour {


	[SerializeField] private float moveSpeedBase;
	private float moveSpeed;

	public int playerScore;
	public int enemyScore;

	public Text playerScoreText;
	public Text enemyScoreText;

	[SerializeField]
	SpriteRenderer ballSprite;

	private Rigidbody2D rb;

	// Use this for initialization
	private void Start () {

		rb = gameObject.GetComponent<Rigidbody2D> ();

		StartBall ();
		playerScore = 0;
		enemyScore = 0;

	}
	
	// Update is called once per frame
	private void FixedUpdate () {
		rb.velocity = moveSpeed * (rb.velocity.normalized);

		ChangeBallColor ();
	}

	private void StartBall() {

		moveSpeed = moveSpeedBase;
		transform.position = new Vector2 (0.0f, 0.0f);
		Vector2 startForce = new Vector2 (Random.Range (-360f, 360f), Random.Range (-360f, 360f));
		rb.AddForce (startForce * moveSpeed);

	}

	private void OnTriggerEnter2D(Collider2D col) {

		if (col.gameObject.tag == "EnemyGoal") {
			IncreasePlayerScore ();
			playerScoreText.text = playerScore.ToString();
		}

		if (col.gameObject.tag == "PlayerGoal") {
			IncreaseEnemyScore ();
			enemyScoreText.text = enemyScore.ToString();
		}

	}

	private void IncreasePlayerScore() {

		playerScore = playerScore + 1;
		StartBall ();

	}

	void IncreaseEnemyScore() {

		enemyScore = enemyScore + 1;
		StartBall ();
	}

	private void ChangeBallColor() {

		if(transform.position.x < 0) {

			// change to black
			ballSprite.color = Color.black;

		}

		if(transform.position.x >= 0) {

			// change to white
			ballSprite.color = Color.white;

		}

	}

	private void OnCollisionEnter2D (Collision2D other) {

		if (other.gameObject.tag == "Paddle") {
		
			moveSpeed += .75f;
		}

	}

	public void ResetScore () {
	
		playerScore = 0;
		playerScoreText.text = playerScore.ToString ();
		enemyScore = 0;
		enemyScoreText.text = enemyScore.ToString();
		StartBall ();

	}
}