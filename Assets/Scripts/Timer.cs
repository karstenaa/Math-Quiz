using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class Timer : MonoBehaviour {
	static Image timer;
	float stdTime;
	float time;
	float c;
	// Use this for initialization
	void Awake(){
		timer = GetComponent<Image> ();
	}
	void Start () {
		stdTime = 5;
		c = 5;
	}
	
	// Update is called once per frame
	void Update () {
		timer.fillAmount -= Time.deltaTime * Score.score/c/stdTime;
		if (timer.fillAmount <= 0) {
			GameOver.show ();
		}
	}
	public static void refresh(){
		timer.fillAmount = 1;
	}

}
