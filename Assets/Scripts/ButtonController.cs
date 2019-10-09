using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonController : MonoBehaviour {

	private bool aboutActive = false;

	public Transform PanelAbout;
	public Transform ImageHi;

	// Use this for initialization
	void Start () {
		PanelAbout.gameObject.SetActive (aboutActive);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void viewAbout()
	{
		if (!aboutActive) {
			aboutActive = true;
		} else {
			aboutActive = false;
		}
		ImageHi.gameObject.SetActive (!aboutActive);
		PanelAbout.gameObject.SetActive (aboutActive);
	}
}
