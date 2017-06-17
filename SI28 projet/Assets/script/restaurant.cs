using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class restaurant : MonoBehaviour {
	public Image angrygirl2;
	public Image stargirl2;
	public Image click2;
	public Text textgirl2;
	public AudioSource audioRestaurant ;
	public bool isOverRestaurant = false;
	public bool isPlayingRestaurant = false;
	// Use this for initialization
	public void OnMouseOver()
	{
			Debug.Log("Mouse enter");
			angrygirl2.enabled = false;
			stargirl2.enabled = true;
			click2.enabled = true;
			textgirl2.text = "Ce chinois semble m'appeler. C'est vrai que ça sent bon... Allons voir de plus près";
			isOverRestaurant = true;
	}
	public void OnMouseExit()
	{
			stargirl2.enabled = false;
			click2.enabled = false;
			Debug.Log("Mouse exit");
			isOverRestaurant = false;
	}
	public void Update()
	{
		if (Input.GetMouseButtonDown(0)){
			Debug.Log("Pressed left click.");
			Application.LoadLevel("scene_restaurant");
		}
		if(isOverRestaurant==true && isPlayingRestaurant==false){
			audioRestaurant.Play();
			isPlayingRestaurant = true;
		}
		if(isOverRestaurant==false && isPlayingRestaurant==true){
			audioRestaurant.Stop();
			isPlayingRestaurant = false;
		}
	}
}
