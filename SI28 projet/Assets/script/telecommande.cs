using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class telecommande : MonoBehaviour {

	public Image telecommande_basic;
	public Image active_mic;
	public Image active_enr;
	public Image active_parl;
	public Text textgirl;
	// Use this for initialization
	public void OnMouseOver()
	{
		textgirl.text = "Ceci est ma télécommande magique, elle me permet d'enregistrer ma voix et de savoir si le serveur m'a compris ou non";
	}
	public void OnMouseExit()
	{
	}
	public void Update()
	{
		if (Input.GetKeyDown("y")){
			active_mic.enabled = true;
			active_enr.enabled = false;
			active_parl.enabled = false;
		}
		if (Input.GetKeyDown("r")){
			active_enr.enabled = true;
			active_parl.enabled = false;
			active_mic.enabled = false;
		}
		if (Input.GetKeyDown("s")){
			active_parl.enabled = true;
			active_mic.enabled = false;
			active_enr.enabled = false;
		}
	}
}
