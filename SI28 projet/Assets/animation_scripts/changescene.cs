using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
		

public class changescene : MonoBehaviour {

	public void next()
	{
		 Application.LoadLevel("testok");
	}
	public void next1()
	{
		Application.LoadLevel("start");
	}
	public void next2()
	{
		Application.LoadLevel("finish");
	}
	public void next3()
	{
		Application.LoadLevel("testok");
	}
}
