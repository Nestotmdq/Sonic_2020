using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CaidaVacio : MonoBehaviour {
/* 
	public GameObject  soundFall;
	public Text vidaShow;
	
	void OnTriggerEnter2D(Collider2D other)
	{
	   if(other.gameObject.tag == "empuje"){
		   gameObject.GetComponent<PlayerControler>().enabled = false;
		   gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(150f,0));
	   }		
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
	gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0,800f));
	StartCoroutine ("Wait");
	 }
	 }
	 IEnumerator Wait(){
		 yield return new WaitForSeconds(1);
		 gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(-250f,0));
         StartCoroutine("Rigitrue");
		 gameObject.GetComponent<Rigidbody2D>().mass = 1.5f;
		 gameObject.GetComponent<PlayerControler>().enabled = true;
	 }

	 IEnumerator Rigitrue(){
		 yield return new WaitForSeconds(3);
		 gameObject.GetComponent<Animator>().SetBool("wakeup",true);
		 gameObject.GetComponent<SpriteRenderer>().enabled = true;
		 gameObject.GetComponent<Rigidbody2D>().mass = 1;

         DataBank.dataBank.SetVidas(-0.5f);
      //   Debug.Log("quedan  "+DataBank.dataBank.GetVidas());
		float number = DataBank.dataBank.GetVidas();

		 vidaShow.text =  number +"";
	
	 }
	 
		*/
	}

	 


