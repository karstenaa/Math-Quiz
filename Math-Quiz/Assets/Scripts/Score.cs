using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Score : MonoBehaviour {

	public static int score = 0;
	static Text textScore;
	// Use this for initialization
	void Awake(){
		textScore = GetComponentsInChildren<Text> () [0];
	}
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {

	}
	static public void reset(){
		score = 0;
		textScore.text = "Score\n0";
	}
	static public void addPoint(){
		score++;
		textScore.text= "Score\n" + score;
	}
}
