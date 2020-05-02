using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CaidaVacio : MonoBehaviour {

	public GameObject soundFall;

 void OnTriggerEnter2D(Collider2D other) {
		if(other.gameObject.tag == "vacio"){
			Debug.Log("me cai al vacio");


			Instantiate(soundFall);

			gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0,50f));
			gameObject.GetComponent<Rigidbody2D>().mass = 2;
			gameObject.GetComponent<Animator>().SetBool("caida",true);
			
		}
	}
		
	}

