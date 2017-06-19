using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LvlManager : MonoBehaviour {
	static public int score=0;
	public Text yourscore;
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void AddPoints(int points)
	{
		score += points;
		if (score == 4)
			Application.LoadLevel (3);
	}
	void OnGUI()
	{
			yourscore.text = ("Score: " + score);
	}	
}
