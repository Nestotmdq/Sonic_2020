using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ControlCaida : MonoBehaviour {
     
	public GameObject soundFall,gameover;
	public Text textoScore,lifecanvas,ringtext;
	PlayerControler pc;
	Rigidbody2D rb;
	Animator an;
	SpriteRenderer sr;
	CircleCollider2D bc;
	PlayerControler  cj;
	
	void Start(){
	             pc = gameObject.GetComponent<PlayerControler>();
	             rb = gameObject.GetComponent<Rigidbody2D>();
                 an = gameObject.GetComponent<Animator>();
	             sr = gameObject.GetComponent<SpriteRenderer>();
	             bc = gameObject.GetComponent<CircleCollider2D>();  
	             cj = PlayerControler.playerControler;
				}

    void OnTriggerEnter2D(Collider2D other){
		                                   if(other.gameObject.tag == "vacio"){
																			   Instantiate(soundFall);
		                                                                       pc.enabled = false;
		                                                                       an.SetBool("caida",true);
																			   an.SetBool("wakeup",true);
										   }}
    private void OnCollisionEnter2D(Collision2D other) {
								                        if(other.gameObject.tag == "fondo"){
                                		                                                    sr.enabled = false;
		                                                                                    an.SetBool("wakeup",false);
			                                                                                rb.AddForce(new Vector2(-350f,0));
			                                                                                bc.enabled = false;
			                                                                                rb.AddForce(new Vector2(0,700f));
						                                                                    StartCoroutine ("Wait");
			                                                                                StartCoroutine ("Wait2");
								                                                            DataBank.dataBank.SetVidas(-1);
																							DataBank.dataBank.cerorings();
																							ringtext.color = Color.red;  
																							ringtext.text= "0";
																							 



																							int resto = DataBank.dataBank.GetVidas();
																							if(resto == -1){
																							               Music.music.musicoff();
																							               Instantiate(gameover);
																							               Over.show();	
																										   pc.enabled = false;
																										   lifecanvas.color = Color.red;
																										   lifecanvas.text = "0";
																										   
																							}
																							

							                                                              
								                                                            }
	                                                   }

	IEnumerator Wait(){
                       yield return new WaitForSeconds(1);
	                   bc.enabled = true;
	                  }
	IEnumerator Wait2(){
                        yield return new WaitForSeconds(2);
                        pc.enabled = true;
						if(DataBank.dataBank.GetVidas() == -1){sr.enabled = false;}
					    else
	                    sr.enabled = true;

                       }
	}





	




	

