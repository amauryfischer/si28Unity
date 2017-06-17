using System;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
public class restaurantfrancais : MonoBehaviour
{
    public bool isOverrestaurantfrancais = false;
    public bool isPlayingrestaurantfrancais = false;
    public AudioSource audiorestaurantfrancais ;
    public Image borderboy;
    public Image angryboy;
    public Image starboy;
    public Image boyfont;
    public Text textboy;

    public void OnMouseOver()
    {
        Debug.Log("Mouse enter");
        isOverrestaurantfrancais = true;
        borderboy.enabled = true;
        angryboy.enabled = true;
        starboy.enabled = true;
        boyfont.enabled = true;
        textboy.enabled = true;
        textboy.text = "J'aimerais avoir la carte s'il vous plait !";
    }
    public void OnMouseExit()
    {
        Debug.Log("Mouse exit");
        isOverrestaurantfrancais = false;
        borderboy.enabled = false;
        angryboy.enabled = false;
        starboy.enabled = false;
        boyfont.enabled = false;
        textboy.enabled = false;
    }
    public void Update()
    {
      if(isOverrestaurantfrancais==true && isPlayingrestaurantfrancais==false){
        audiorestaurantfrancais.Play();
        isPlayingrestaurantfrancais = true;
      }
      if(isOverrestaurantfrancais==false && isPlayingrestaurantfrancais==true){
        audiorestaurantfrancais.Stop();
        isPlayingrestaurantfrancais = false;
      }
    }
}
