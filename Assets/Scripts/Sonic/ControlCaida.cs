using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ControlCaida : MonoBehaviour {
     
	public GameObject soundFall;
	public Text textoScore;
	PlayerControler pc;
	Rigidbody2D rb;
	Animator an;
	SpriteRenderer sr;
	BoxCollider2D bc;
	
	void Start(){
	pc = gameObject.GetComponent<PlayerControler>();
	rb = gameObject.GetComponent<Rigidbody2D>();
    an = gameObject.GetComponent<Animator>();
	sr = gameObject.GetComponent<SpriteRenderer>();
	bc = gameObject.GetComponent<BoxCollider2D>();            
				}

	private void OnTriggerEnter2D(Collider2D other){
		                                            if(other.gameObject.tag == "empuje"){
                                                                                         pc.enabled = false;
											                                             rb.AddForce(new Vector2(150f,0));
	                                       	                                            }
                                                    if(other.gameObject.tag == "empuje2"){
									   		                                              pc.enabled = false;
											                                              rb.AddForce(new Vector2(-150f,0));
		                                                                                 }
		                                            if(other.gameObject.tag == "vacio"){
		                                                                                Instantiate(soundFall);
		                                                                                pc.enabled = false;
		                                                                                an.SetBool("wakeup",false);
		                                                                                an.SetBool("caida",true);
										                                               }
                                        	       }
												   
    private void OnCollisionEnter2D(Collision2D other) {
								                        if(other.gameObject.tag == "fondo"){
                                		                                                    sr.enabled = false;
			                                                                                an.SetBool("caida",false);
		                                                                                    an.SetBool("wakeup",true);
			                                                                                rb.AddForce(new Vector2(-300f,0));
			                                                                                bc.enabled = false;
			                                                                                rb.AddForce(new Vector2(0,600f));
						                                                                    StartCoroutine ("Wait");
			                                                                                StartCoroutine ("Wait2");
								                                                            DataBank.dataBank.SetVidas(-1);
							                                                                int muestra = DataBank.dataBank.GetVidas();
									                                                        textoScore.text = muestra + "";
								                                                            }
	                                                   }

	IEnumerator Wait(){
                       yield return new WaitForSeconds(1);
	                   bc.enabled = true;
	                  }
	IEnumerator Wait2(){
                        yield return new WaitForSeconds(2);
                        pc.enabled = true;
	                    sr.enabled = true;
                       }
					   

	}





	




	

