using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class LiveShow : MonoBehaviour {

	public Sprite[]  lives;
	public Image livesUI;

	void Start () {
		


	}
	
	
	void FixedUpdate () {
		Debug.Log(DataBank.dataBank.GetVidas());
		livesUI.sprite  = lives[DataBank.dataBank.GetVidas()];
	}
}
