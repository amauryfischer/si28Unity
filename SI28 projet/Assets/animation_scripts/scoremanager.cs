using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scoremanager : MonoBehaviour {
	public static int score;
	/*Text text;
	bool food = false;
	public Transform zonecheck;
	int add=1;
	float checkRadius=2f;
	public LayerMask Whatsfood;
	/*bool plate;
	public Transform platecheck;
	float plateRadius=0.2f;
	public LayerMask Whatsplate;*/
	// Use this for initialization
	void Start () 
	{
		//text = GetComponent<Text>;
		score = 0;
	}

	// Update is called once per frame
	void Update () 
	{
		//plate = Physics2D.OverlapCircle (platecheck.position, plateRadius, Whatsplate);
		/*food = Physics2D.OverlapCircle (zonecheck.position, checkRadius, Whatsfood);
		//if (plate)
		//	add = 0;
		if (food ) 
			score += add;
		Debug.Log ("score="+score);

*/
		
	}
	void OnTriggerEnter2D(Collider2D other) 
	{
		if(other.gameObject.CompareTag("plate"))
		{
			score +=1;
			other.gameObject.SetActive(false);		
		}
	}
//	public static void AddPoints (int pointstoAdd)
}
