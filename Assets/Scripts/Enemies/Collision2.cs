using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision2 : MonoBehaviour {
public GameObject soundImpact;
	
  void OnCollisionEnter2D(Collision2D other) {
		
	
		if(other.gameObject.tag == "player"){
			
            if(PlayerControler.playerControler.GetcanHit() == true){
			 	gameObject.GetComponent<BoxCollider2D>().enabled = false;
                Instantiate(soundImpact);
				gameObject.GetComponent<Animator>().SetBool("fire",true);
				DataBank.dataBank.sumascore(10);
			    Destroy(gameObject,1);
			}
			if(PlayerControler.playerControler.GetcanHit() == false){
				                                                    Destroy(gameObject);
		                                                         	}
		}
	}
}
