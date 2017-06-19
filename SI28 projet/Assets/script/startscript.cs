using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class startscript : MonoBehaviour {
	public Image borderboy;
	public Image angryboy;
	public Image starboy;
	public Image boyfont;
	public Text textboy;
	public Image bordergirl;
	public Image angrygirl;
	public Image stargirl;
	public Image girlfont;
	public Text textgirl;
	public Image smilingboy;
	// Use this for initialization
	void Start () {
		borderboy.enabled = false;
		angryboy.enabled = false;
		starboy.enabled = false;
		boyfont.enabled = false;
		textboy.enabled = false;
		bordergirl.enabled = false;
		angrygirl.enabled = false;
		stargirl.enabled = false;
		girlfont.enabled = false;
		textgirl.enabled = false;
		smilingboy.enabled = false;
	}
}
