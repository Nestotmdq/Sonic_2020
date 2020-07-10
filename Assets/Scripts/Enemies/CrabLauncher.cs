using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrabLauncher : MonoBehaviour {

		void OnCollisionEnter2D(Collision2D other) {
			
		
		if(other.gameObject.tag == "fondo"){
		gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0,600f));
		}
	}
}

