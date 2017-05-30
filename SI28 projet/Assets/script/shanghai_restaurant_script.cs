using System;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
public class shanghai_restaurant_script : MonoBehaviour
{
    public bool isOverShanghaiRestaurant = false;
    public bool isPlayingShanghaiRestaurant = false;
    public AudioSource audioShanghaiRestaurant ;
    public Image bordergirl;
    public Image angrygirl;
    public Image stargirl;
    public Image girlfont;
    public Text textgirl;
    public GameObject nourriture;

    public void OnMouseOver()
    {
      if(!nourriture.GetComponent<nourriture>().isOverNourriture) {
        Debug.Log("Mouse enter");
        isOverShanghaiRestaurant = true;
        bordergirl.enabled = true;
        angrygirl.enabled = false;
        stargirl.enabled = true;
        girlfont.enabled = true;
        textgirl.enabled = true;
        textgirl.text = "Hmm, ca sent incroyablement bon...";
      }
    }
    public void OnMouseExit()
    {
        Debug.Log("Mouse exit");
        isOverShanghaiRestaurant = false;
        bordergirl.enabled = false;
        angrygirl.enabled = false;
        stargirl.enabled = false;
        girlfont.enabled = false;
        textgirl.enabled = false;
    }
    public void Update()
    {
      if(isOverShanghaiRestaurant==true && isPlayingShanghaiRestaurant==false && !nourriture.GetComponent<nourriture>().isOverNourriture){
        audioShanghaiRestaurant.Play();
        isPlayingShanghaiRestaurant = true;
      }
      if(isOverShanghaiRestaurant==false && isPlayingShanghaiRestaurant==true || nourriture.GetComponent<nourriture>().isOverNourriture){
        audioShanghaiRestaurant.Stop();
        isPlayingShanghaiRestaurant = false;
      }
    }
}
