using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class nourriture : MonoBehaviour {
	public Image angrygirl2;
	public Image stargirl2;
	public Image bordergirl2;
	public Image girlfont2;
	public Image cryinggirl;
	public Text textgirl2;
	public AudioSource audioNourriture ;
	public bool isOverNourriture = false;
	public bool isPlayingNourriture = false;
	// Use this for initialization
	public void Start()
	{
		cryinggirl.enabled = false;
	}
	public void OnMouseOver()
	{
			Debug.Log("Mouse enter");
			angrygirl2.enabled = false;
			stargirl2.enabled = false;
			bordergirl2.enabled = true;
			textgirl2.enabled = true;
			girlfont2.enabled = true;
			cryinggirl.enabled = true;
			textgirl2.text = "Je crois qu'il me demande si j'aimerais manger ici, je ne vais jamais réussir à commander !!!";
			isOverNourriture = true;
	}
	public void OnMouseExit()
	{
			angrygirl2.enabled = false;
			bordergirl2.enabled = false;
			girlfont2.enabled = false;
			textgirl2.enabled = false;
			stargirl2.enabled = false;
			cryinggirl.enabled = false;
			Debug.Log("Mouse exit");
			isOverNourriture = false;
	}
	public void Update()
	{
		if (Input.GetMouseButtonDown(0)){
			Debug.Log("Pressed left click.");
			Application.LoadLevel("scene_restaurant");
		}
		if(isOverNourriture==true && isPlayingNourriture==false){
			audioNourriture.Play();
			isPlayingNourriture = true;
		}
		if(isOverNourriture==false && isPlayingNourriture==true){
			audioNourriture.Stop();
			isPlayingNourriture = false;
		}
	}
}
