using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeManager : MonoBehaviour {

	public tk2dClippedSprite UpperBar, RightBar, BottomBar, LeftBar, currentBar;
	public float stageTime;

	private float currentStageTime, temp;
	private bool GameOver = false;

	void Start () {
		currentStageTime = stageTime;
	}
	
	void FixedUpdate() {
		currentStageTime -= Time.deltaTime;
		temp += Time.deltaTime;

		if (currentStageTime > stageTime * 0.75f) {
			currentBar = UpperBar;
			currentBar.ClipRect = new Rect((1 / (stageTime * 0.25f)) * temp , 0, 1, 1);
		} else if (currentStageTime > stageTime * 0.5f) {
			UpperBar.ClipRect = new Rect(1, 0, 1, 1);
			currentBar = RightBar;
			currentBar.ClipRect = new Rect((1 / (stageTime * 0.25f)) * (temp-stageTime*0.25f), 0, 1, 1);
		} else if(currentStageTime > stageTime * 0.25f) {
			RightBar.ClipRect = new Rect(1, 0, 1, 1);
			currentBar = BottomBar;
			currentBar.ClipRect = new Rect((1 / (stageTime * 0.25f)) * (temp-stageTime*0.5f), 0, 1, 1);
		} else if(currentStageTime > 0f) {
			BottomBar.ClipRect = new Rect(1, 0, 1, 1);
			currentBar = LeftBar;
			currentBar.ClipRect = new Rect((1 / (stageTime * 0.25f)) * (temp-stageTime*0.75f), 0, 1, 1);
		} else {
			LeftBar.ClipRect = new Rect(1, 0, 1, 1);

			if (!GameOver) {
				GameOver = true;
				iTween.ScaleTo(GameObject.Find("WinnerBanner"), iTween.Hash("x", 1.5, "y", 1.5, "easetype", iTween.EaseType.easeOutElastic, "time", 0.5));
			}
		}
	}
}
