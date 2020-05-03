using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CaidaVacio : MonoBehaviour {

	public GameObject  soundFall;

	void OnTriggerEnter2D(Collider2D other)
	{
	   if(other.gameObject.tag == "vacio"){
		   Instantiate(soundFall);
		   gameObject.GetComponent<PlayerControler>().enabled = false;
		   gameObject.GetComponent<Animator>().SetBool("wakeup",false);
		   gameObject.GetComponent<Animator>().SetBool("caida",true);
	   }

	}
 void OnTriggerExit2D(Collider2D other) {
	 if(other.gameObject.tag == "vacio"){
	gameObject.GetComponent<SpriteRenderer>().enabled = false;	 
	gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0,1000f));
	StartCoroutine ("Wait");
	 }

	 }

	 IEnumerator Wait(){
		 yield return new WaitForSeconds(1);
		 gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(-400f,0));
         StartCoroutine("Rigitrue");
		 gameObject.GetComponent<Rigidbody2D>().mass = 1.4f;
		 gameObject.GetComponent<PlayerControler>().enabled = true;
		  
	 }


	 IEnumerator Rigitrue(){
		 yield return new WaitForSeconds(3);
		 gameObject.GetComponent<Animator>().SetBool("wakeup",true);
		 gameObject.GetComponent<SpriteRenderer>().enabled = true;
		 gameObject.GetComponent<Rigidbody2D>().mass = 1;

	 }
		
	}

	 


