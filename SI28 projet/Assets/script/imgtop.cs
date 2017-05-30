using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class imgtop : MonoBehaviour {
	public Image currentImage;
	// Use this for initialization

	public void ToHappy() {
		currentImage.sprite = Resources.Load<Sprite> ("image1");
	}
	public void ToAngry() {
		currentImage.sprite = Resources.Load<Sprite> ("image2");
	}
}
