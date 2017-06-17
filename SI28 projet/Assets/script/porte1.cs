using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class porte1 : MonoBehaviour {
	public Image angryboy2;
	public Image starboy2;
	public Image borderboy2;
	public Image boyfont2;
	public Image porte2;
	public Text textboy2;
	/*public AudioSource audioRestaurant ;*/
	public bool isOverPorte1 = false;
	public bool isPlayingPorte1 = false;
	
	// Use this for initialization
	public void OnMouseOver()
	{
			Debug.Log("Mouse enter");
			angryboy2.enabled = false;
			borderboy2.enabled = true;
			boyfont2.enabled = true;
			porte2.enabled = true;
			textboy2.enabled = true;
			starboy2.enabled = true;
			textboy2.text = "J'ai un petit creux, je pense que je vais manger ici";
			isOverPorte1 = true;
	}
	public void OnMouseExit()
	{
			angryboy2.enabled = false;
			borderboy2.enabled = false;
			boyfont2.enabled = false;
			porte2.enabled = false;
			textboy2.enabled = false;
			starboy2.enabled = false;
			Debug.Log("Mouse exit");
			isOverPorte1 = false;
	}
	
	public void Update()
	{
		if (Input.GetMouseButtonDown(0)){
			Debug.Log("Pressed left click.");
			Application.LoadLevel("scene_restaurant");
		}
		if(isOverPorte1==true && isPlayingPorte1==false){
			/*audioRestaurant.Play();*/
			isPlayingPorte1 = true;
		}
		if(isOverPorte1==false && isPlayingPorte1==true){
			/*audioRestaurant.Stop();*/
			isPlayingPorte1 = false;
		}
	}
}
