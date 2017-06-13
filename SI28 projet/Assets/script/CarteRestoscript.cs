using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class carteResto : MonoBehaviour {
	public Image angryboy3;
	public Image starboy3;
	public Image borderboy3;
	public Image boyfont3;
	public Image cryingboy3;
	public Text textboy3;
	//public AudioSource audioNourriture ;
	public bool isOverCarteResto = false;
	public bool isPlayingCarteResto = false;
	// Use this for initialization
	public void Start()
	{
		cryingboy3.enabled = false;
	}
	public void OnMouseOver()
	{
			Debug.Log("Mouse enter");
			angryboy3.enabled = false;
			starboy3.enabled = false;
			borderboy3.enabled = true;
			textboy3.enabled = true;
			boyfont3.enabled = true;
			cryingboy3.enabled = true;
			textboy3.text = "J'aimerais bien comprendre cette carte pour commander...";
			isOverCarteResto = true;
	}
	public void OnMouseExit()
	{
			angryboy3.enabled = false;
			borderboy3.enabled = false;
			boyfont3.enabled = false;
			textboy3.enabled = false;
			starboy3.enabled = false;
			cryingboy3.enabled = false;
			Debug.Log("Mouse exit");
			isOverCarteResto = false;
	}
	public void Update()
	{
		if (Input.GetMouseButtonDown(0)){
			Debug.Log("Pressed left click.");
			Application.LoadLevel("scene_3");
		}
		if(isOverCarteResto==true && isPlayingCarteResto==false){
			//audioNourriture.Play();
			isPlayingCarteResto = true;
		}
		if(isOverCarteResto==false && isPlayingCarteResto==true){
			//audioNourriture.Stop();
			isPlayingCarteResto = false;
		}
	}
}