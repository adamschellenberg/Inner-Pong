using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour {

	private int currentPlayerScore;
	private int currentEnemyScore;
	private string winner;

	[SerializeField] private BallController scoreTracker;

	[SerializeField] private Canvas endGameCanvas;
	[SerializeField] private Text winnerText;
	[SerializeField] private int goalScore;


	// Use this for initialization
	private void Start () {

		endGameCanvas.enabled = false;

	}

	// Update is called once per frame
	private void Update () {

		currentPlayerScore = scoreTracker.playerScore;
		currentEnemyScore = scoreTracker.enemyScore;

		if (currentPlayerScore == goalScore) {
			EndGame ();
			winner = "White";
		} else if (currentEnemyScore == goalScore) {
			EndGame ();
			winner = "Black";
		}

	}

	private void EndGame() {

		Time.timeScale = 0;
		winnerText.text = winner + " wins!";
		endGameCanvas.enabled = true;

	}

	public void RestartGame() {

		endGameCanvas.enabled = false;
		Time.timeScale = 1;
		scoreTracker.ResetScore ();
	
	}

}
