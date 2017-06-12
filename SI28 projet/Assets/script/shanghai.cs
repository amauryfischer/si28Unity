using System;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
public class shanghai : MonoBehaviour
{
    public bool isOverShanghai = false;
    public bool isPlayingShanghai = false;
    public AudioSource audioShanghai ;
    public Image bordergirl;
    public Image angrygirl;
    public Image stargirl;
    public Image girlfont;
    public Text textgirl;
    public GameObject restaurant;

    public void OnMouseOver()
    {
      if(!restaurant.GetComponent<restaurant>().isOverRestaurant) {
        Debug.Log("Mouse enter");
        isOverShanghai = true;
        bordergirl.enabled = true;
        angrygirl.enabled = true;
        stargirl.enabled = true;
        girlfont.enabled = true;
        textgirl.enabled = true;
        textgirl.text = "Oh j'ai l'impression qu'il y a beaucoup de monde dans les rues de Shanghai. D'un côté, ils sont 24 millions d'habitants...";
      }
    }
    public void OnMouseExit()
    {
        Debug.Log("Mouse exit");
        isOverShanghai = false;
        bordergirl.enabled = false;
        angrygirl.enabled = false;
        stargirl.enabled = false;
        girlfont.enabled = false;
        textgirl.enabled = false;
    }
    public void Update()
    {
      if(isOverShanghai==true && isPlayingShanghai==false && !restaurant.GetComponent<restaurant>().isOverRestaurant){
        audioShanghai.Play();
        isPlayingShanghai = true;
      }
      if(isOverShanghai==false && isPlayingShanghai==true || restaurant.GetComponent<restaurant>().isOverRestaurant){
        audioShanghai.Stop();
        isPlayingShanghai = false;
      }
    }
}
