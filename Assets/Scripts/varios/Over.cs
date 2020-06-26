using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Over : MonoBehaviour {

	public GameObject GOText;
	public static GameObject GOStatic;

	void Start () {
		Over.GOStatic = GOText;
		Over.GOStatic.gameObject.SetActive(false);
	}
	
	// Update is called once per frame
	public static void show(){
		Over.GOStatic.gameObject.SetActive(true);
		
	}
}
