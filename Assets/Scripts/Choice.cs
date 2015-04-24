using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class Choice : MonoBehaviour {
	public bool answer;
	Text textChoice;
	// Use this for initialization
	void Awake(){
		textChoice = GetComponentsInChildren<Text> () [0];
	}
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
	
	}
	public void clicked(){
		if (answer) {
			Debug.Log("Correct Answer");
			Score.addPoint();
			Timer.refresh();
			Play.setQuestion();
		}
		else {
			Debug.Log("Wrong Answer");
			GameOver.show();
		}
	}
	public void assignChoice(int value, bool answer){
		textChoice.text = value.ToString();
		this.answer = answer;
	}
}