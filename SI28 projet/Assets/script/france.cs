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

    public void OnMouseOver()
    {
        Debug.Log("Mouse enter");
        isOverfrance = true;
        borderboy.enabled = true;
        angryboy.enabled = true;
        starboy.enabled = true;
        boyfont.enabled = true;
        textboy.enabled = true;
        textboy.text = "Les rues sont désertes à cette heure ci...";
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
      if(isOverfrance==true && isPlayingfrance==false){
        audiofrance.Play();
        isPlayingfrance = true;
      }
      if(isOverfrance==false && isPlayingfrance==true){
        audiofrance.Stop();
        isPlayingfrance = false;
      }
    }
}
