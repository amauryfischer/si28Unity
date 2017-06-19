using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scorelayour : MonoBehaviour {

	public int score=0;
	public Text yourscore;
	// Use this for initialization
	void Start () {

	}
		
	void Update () {
		yourscore.text=("Score: " + score);
	}

	public void AddPoints(int points)
	{
		score += points;
	}
}
