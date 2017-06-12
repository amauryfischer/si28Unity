using System;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
public class france : MonoBehaviour
{
    public bool isOverfrance = false;
    public bool isPlayingfrance = false;
    public AudioSource audiofrance ;
    public Image borderboy;
    public Image angryboy;
    public Image starboy;
    public Image boyfont;
    public Text textboy;
	public GameObject porte1;

    public void OnMouseOver()
    {
		if(!porte1.GetComponent<porte1>().isOverPorte1)
        { 	Debug.Log("Mouse enter");
			isOverfrance = true;
			borderboy.enabled = true;
			angryboy.enabled = true;
			starboy.enabled = true;
			boyfont.enabled = true;
			textboy.enabled = true;
			textboy.text = "Les rues paraissent vides ici, par rapport à la Chine";
		}
    }
    public void OnMouseExit()
    {
        Debug.Log("Mouse exit");
        isOverfrance = false;
        borderboy.enabled = false;
        angryboy.enabled = false;
        starboy.enabled = false;
        boyfont.enabled = false;
        textboy.enabled = false;
    }
    public void Update()
    {
      if(isOverfrance==true && isPlayingfrance==false && !porte1.GetComponent<porte1>().isOverPorte1){
        audiofrance.Play();
        isPlayingfrance = true;
      }
      if(isOverfrance==false && isPlayingfrance==true || porte1.GetComponent<porte1>().isOverPorte1){
        audiofrance.Stop();
        isPlayingfrance = false;
      }
    }
	
}
