using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Collision : MonoBehaviour {

	public GameObject soundImpact;

	
	void OnTriggerEnter2D(Collider2D other)
	{
		if(other.gameObject.tag == "player"){
			
            if(PlayerControler.playerControler.GetcanHit() == true){
             Debug.Log("Sonic ataca");
				gameObject.GetComponent<Animator>().SetBool("fire",true);
				Destroy(gameObject,1);
				Instantiate(soundImpact);
			}

		}

	}


	/* 
  void OnCollisionEnter2D(Collision2D other) {
   if(other.gameObject.tag == "player"){
	   Debug.Log("Phantom fue impactado por sonic");
	   if(PlayerControler.playerControler.GetcanHit() == true){
		   Debug.Log("muere phantom");
		    gameObject.GetComponent<Animator>().SetBool("fire",true);
		  Destroy(gameObject,1);
	   }
   }
 }
*/





}
