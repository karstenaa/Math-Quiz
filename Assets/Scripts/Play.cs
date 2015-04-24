using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class Play : MonoBehaviour {
	private static Choice[] choices;
	private static Question[] questions;
	// Use this for initialization
	void Awake(){
		choices = GetComponentsInChildren<Choice> ();
		questions = GetComponentsInChildren<Question> ();
	}
	void Start () {
		play ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	static public void play(){
	
		Score.reset ();
		Timer.refresh ();
		setQuestion ();
	}
	static public void setQuestion(){
		int q1 = Random.Range (0,10);
		int q2 = Random.Range (0,10); 
		int answer=0;
		string operations = "+-x";
		char operation = operations[Random.Range(0,3)];
		if (operation == '-') {
//			if (q1 < q2) {
//				int temp = q1;
//				q1 = q2;
//				q2 = temp;
//			}
			answer = q1 - q2;
		}
		else if (operation == '+') {
			answer = q1 + q2;
		}
		else if (operation == 'x') {
			answer = q1 * q2;
		}
		answer = Mathf.Abs (answer);
		questions [0].assignQuestion (q1);
		questions [1].assignQuestion (q2);
		questions [2].assignQuestion (operation);
		answer = answer % 10;
		setAnswer (answer);
	}
	static public void setAnswer(int answer){
		List<int> answerList = new List<int>();
		int position = Random.Range (0, 4);
		for (int i=0; i<10; i++) {
			answerList.Add (i);
		}
		answerList.Remove (answer);
		for (int i=0; i<4;i++){
			if(position==i){
				choices[i].assignChoice(answer,true);
			}
			else{
				int wrongAnswer = answerList[Random.Range(0,answerList.Count)];
				answerList.Remove(wrongAnswer);
				choices[i].assignChoice(wrongAnswer,false);
			}
			
		}
	}
}
