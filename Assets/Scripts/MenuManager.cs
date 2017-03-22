using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuManager : MonoBehaviour {

	private string currentScene = "Main";
	public GameObject PlayButton, ShopButton, AchievementsButton, ChallengerButton;

	void Start () {
		
	}
	
	void Update () {
		
	}

	private void ResetAllButtons() {
		PlayButton.GetComponent<tk2dTextMesh>().color = Color.white;
		ShopButton.GetComponent<tk2dTextMesh>().color = Color.white;
		AchievementsButton.GetComponent<tk2dTextMesh>().color = Color.white;
		ChallengerButton.GetComponent<tk2dTextMesh>().color = Color.white;
	}

	public void SwitchScene(string s) {

		ResetAllButtons();

		switch (s) {
			case "Play":
				PlayButton.GetComponent<tk2dTextMesh>().color = Color.red;
				break;

			case "Shop":
				ShopButton.GetComponent<tk2dTextMesh>().color = Color.red;
				break;

			case "Achievements":
				AchievementsButton.GetComponent<tk2dTextMesh>().color = Color.red;
				break;

			case "Challenger":
				ChallengerButton.GetComponent<tk2dTextMesh>().color = Color.red;
				break;
		}
	}
}
