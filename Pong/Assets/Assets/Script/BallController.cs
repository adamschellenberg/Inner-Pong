using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BallController : MonoBehaviour {

	public float moveSpeed;

	public int playerScore;
	public int enemyScore;

	public Text playerScoreText;
	public Text enemyScoreText;

	[SerializeField]
	SpriteRenderer ballSprite;

	private Rigidbody2D rb;

	// Use this for initialization
	void Start () {

		rb = gameObject.GetComponent<Rigidbody2D> ();

		StartBall ();
		playerScore = 0;
		enemyScore = 0;

	}
	
	// Update is called once per frame
	void Update () {
		rb.velocity = moveSpeed * (rb.velocity.normalized);

		playerScoreText.text = playerScore.ToString();
		enemyScoreText.text = enemyScore.ToString();

		ChangeBallColor ();
	}

	void StartBall() {

		transform.position = new Vector2 (0.0f, 0.0f);
		Vector2 startForce = new Vector2 (Random.Range (-360f, 360f), Random.Range (-360f, 360f));
		rb.AddForce (startForce * moveSpeed);

	}

	void OnTriggerEnter2D(Collider2D col) {

		if (col.gameObject.tag == "EnemyGoal") {
			IncreasePlayerScore ();
		}

		if (col.gameObject.tag == "PlayerGoal") {
			IncreaseEnemyScore ();
		}

	}

	void IncreasePlayerScore() {

		playerScore = playerScore + 1;
		StartBall ();

	}

	void IncreaseEnemyScore() {

		enemyScore = enemyScore + 1;
		StartBall ();
	}

	void ChangeBallColor() {

		if(transform.position.x < 0) {

			// change to black
			ballSprite.color = Color.black;

		}

		if(transform.position.x >= 0) {

			// change to white
			ballSprite.color = Color.white;

		}

	}
}