using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Question : MonoBehaviour {

	Text textQuestion;
	// Use this for initialization
	void Awake(){
		textQuestion = GetComponentsInChildren<Text> ()[0];
	}
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	public void assignQuestion(int value){
		Debug.Log (textQuestion);
		textQuestion.text = value.ToString ();
	}
	public void assignQuestion(char value){
		textQuestion.text = value.ToString();
	}
}
