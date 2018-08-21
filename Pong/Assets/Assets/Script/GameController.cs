using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour {

	int currentPlayerScore;
	int currentEnemyScore;

	BallController scoreTracker;
	GameObject score;

	// Use this for initialization
	void Start () {
		score = GameObject.Find ("Ball");

		scoreTracker = score.GetComponent<BallController> ();

	}

	// Update is called once per frame
	void Update () {

		currentPlayerScore = scoreTracker.playerScore;
		currentEnemyScore = scoreTracker.enemyScore;

		if (currentPlayerScore == 7) {
			EndGame ();
			Debug.Log ("Player wins!");
		} else if (currentEnemyScore == 7) {
			EndGame ();
			Debug.Log ("Player loses!");
		}

	}

	void EndGame() {
		Time.timeScale = 0F;
	}

}
