using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class timer : MonoBehaviour {
	static public int score = 0;

	public int timeleft=20;
	public Text countdown;
	// Use this for initialization
	void Start () {
		StartCoroutine ("losetime");
	}
	
	// Update is called once per frame
	void Update () {
		countdown.text = ("Time left: " + timeleft);
		if (timeleft <= 0) 
		{
			StopCoroutine ("losetime");
			Application.LoadLevel (3);
		}
	}
	IEnumerator losetime()
	{
		while (true) {
			yield return new WaitForSeconds (1);
			timeleft--;
		}
	}
}
