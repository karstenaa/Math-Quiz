using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Result : MonoBehaviour {

	static int score;
	static int highscore;
	static Text textScore;
	static Text textHighScore;
	// Use this for initialization
	void Awake(){
		textScore = GetComponentsInChildren<Text> () [0];
		textHighScore = GetComponentsInChildren<Text> () [1];
	}
	void Start () {

		highscore = PlayerPrefs.GetInt ("highscore",0);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnDestroy(){
		PlayerPrefs.SetInt ("highscore", highscore);
	}
	static public void assignResult(int currentScore){
		score = currentScore;
		textScore.text= "Score\n" + score;
		if (score > highscore) {
			highscore = score;
		}
		textHighScore.text = "Best\n" + highscore;
	}
}
