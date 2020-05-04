using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ControlCaida : MonoBehaviour {
     
	public GameObject soundFall;
	public Text textoScore;
	
	void OnTriggerEnter2D(Collider2D other){
		if(other.gameObject.tag == "empuje"){
											gameObject.GetComponent<PlayerControler>().enabled = false;
											gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(150f,0));
	                                       	}

        if(other.gameObject.tag == "empuje2"){
									   		gameObject.GetComponent<PlayerControler>().enabled = false;
											gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(-150f,0));
		                                     }
		if(other.gameObject.tag == "vacio"){
		                                    Instantiate(soundFall);
		                                    gameObject.GetComponent<PlayerControler>().enabled = false;
		                                    gameObject.GetComponent<Animator>().SetBool("wakeup",false);
		                                    gameObject.GetComponent<Animator>().SetBool("caida",true);
										   }
                                        	}
    private void OnCollisionEnter2D(Collision2D other) {
		                                    if(other.gameObject.tag == "fondo"){
                                		 	gameObject.GetComponent<SpriteRenderer>().enabled = false;
			                                gameObject.GetComponent<Animator>().SetBool("caida",false);
			                                gameObject.GetComponent<Animator>().SetBool("wakeup",true);
			                                gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(-300f,0));
			                                gameObject.GetComponent<BoxCollider2D>().enabled = false;
			                                gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0,600f));
						                    StartCoroutine ("Wait");
			                                StartCoroutine ("Wait2");
											DataBank.dataBank.SetVidas(-1);
											int muestra = DataBank.dataBank.GetVidas();
											textoScore.text = muestra + "";
	                                                	}
	                                                   }

	IEnumerator Wait(){
                       yield return new WaitForSeconds(1);
	                   gameObject.GetComponent<BoxCollider2D>().enabled = true;
	                  }
	IEnumerator Wait2(){
                        yield return new WaitForSeconds(2);
                        gameObject.GetComponent<PlayerControler>().enabled = true;
	                    gameObject.GetComponent<SpriteRenderer>().enabled = true;
                       }
	}





	




	

