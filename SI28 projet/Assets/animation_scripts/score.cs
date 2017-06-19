using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class score : MonoBehaviour {

	//public GameObject lvlManager;
	//LvlManager lvlman;
	// Use this for initialization
	public LvlManager lvlman;
	public int foodpoint=1;	
	public 
	void Start () {
		//lvlman = lvlManager.GetComponent<LvlManager> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter2D(Collider2D other)
	{
		Debug.Log ("inside trigger");
		if (other.tag == "plate") 
		{
			lvlman.AddPoints (foodpoint);
			Destroy (this.gameObject);
		}
	}
}
