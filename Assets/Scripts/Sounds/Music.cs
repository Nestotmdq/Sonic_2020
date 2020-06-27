using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Music : MonoBehaviour {

	public static Music music;
	void Start () {
		music = this;
	}
	
	// Update is called once per frame
	public void musicoff(){
		Destroy(gameObject);
	}
}
