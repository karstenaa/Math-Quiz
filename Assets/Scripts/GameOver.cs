using UnityEngine;
using System.Collections;

public class GameOver : MonoBehaviour {
	static GameObject gameOver;
	// Use this for initialization
	void Awake(){
		gameOver = gameObject;

	}
	void Start () {
		hide ();
		//gameObject.enabled = 
	}
	
	// Update is called once per frame
	void Update () {

	}
	public static void show(){
		Result.assignResult (Score.score);
		gameOver.SetActive (true);
	}
	public void hide(){
		gameObject.SetActive (false);
	}
	public void buttonReplay(){
		hide ();
		Play.play ();
	}
	public void buttonMainMenu(){
		Application.LoadLevel ("Menu");
	}
}
