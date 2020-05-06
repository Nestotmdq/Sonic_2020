using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControler : MonoBehaviour {

	
    public static PlayerControler playerControler;
	public GameObject jumpSound;
	public float fuerza;
	public float fuerzaSalto;
	bool canJump;
    bool canHit;
	Animator an;
	Rigidbody2D rb;
	SpriteRenderer sr;
	public GameObject soundHit;
	bool keyActive;
	BoxCollider2D bc;
	
	void Start(){
		
		playerControler = this;
		an = gameObject.GetComponent<Animator>();
		rb = gameObject.GetComponent<Rigidbody2D>();
		sr = gameObject.GetComponent<SpriteRenderer>();
		bc = gameObject.GetComponent<BoxCollider2D>();
		keyActive = true;
	}
	private void FixedUpdate () {

                                 if(keyActive == true){
		                                               if(Input.GetKey("left")){
				                                                                left();
                         	                                                	}
		                                               if(Input.GetKey("right")){
							                                                	 right();
		                                                                        }
		                                               if(Input.GetKeyDown("up") && canJump){
                                                                                            up(fuerzaSalto);
		                                                                                    }
	                                            	if(!Input.GetKey("left") && !Input.GetKey("right")){
		                                                                                             	an.SetBool("moving",false);
													                                             	   }
	                                            	if(Input.GetKey("left") && Input.GetKeyDown("up")){
														                                            	runnerjump();
                            					    	                                            	}
	                                            	if(Input.GetKey("right") && Input.GetKeyDown("up")){
														                                            	runnerjump();
		                                                                                                }

			                                           }

	                            }
	private void left(){
                		rb.AddForce(new Vector2(fuerza * -1 * Time.deltaTime,0));
		                sr.flipX = true;
		                an.SetBool("moving",true);
                      	}
	private void right(){
		rb.AddForce(new Vector2(fuerza * Time.deltaTime,0));
		sr.flipX = false;
		an.SetBool("moving",true);
	}
	private void runnerjump(){
                             an.SetBool("movjump",true);
						     up(30f);
	                         }
	private void up(float fuerza){
	                             if(canJump == true){
                                                     Instantiate(jumpSound);
	                    				            }
					             canJump = false;
					             rb.AddForce(new Vector2(0,fuerza));
					             an.SetBool("jump",true);
								 canHit = true;
								 }
	void OnCollisionEnter2D(Collision2D coll){
	                                          if(coll.transform.tag == "ground"){
		 								                                         canJump = true;
										                                         an.SetBool("jump",false);
										                                         an.SetBool("movjump",false);
									                                             an.SetBool("caida",false);
																				 canHit = false;
	                                                                            }
																				/* 
											 if(coll.transform.tag == "phanton"){

												 	Debug.Log("Choque con fantom");
													 if(canJump == true){
														 Destroy(gameObject);
													 }

                                                        */
											 }
											  	

	 void OnTriggerEnter2D(Collider2D other) {
			if(other.transform.tag == "phanton"){
                if(canJump == true){
                    Instantiate(soundHit);
                      keyActive = false;
					  StartCoroutine("Wait");
					  an.SetBool("inertia",true);
		              an.SetBool("wakeup",false);
		              an.SetBool("caida",true);
					//  rb.AddForce(new Vector2(0,1000f));
					  bc.enabled = false;
					  //bc.enabled = true;

				}
				
			}
	}
    IEnumerator Wait(){
                       yield return new WaitForSeconds(1);
	                  bc.enabled = true;
					  keyActive = true;	                  }


    public bool GetcanJump(){
	                        return canJump;
                            }
	public bool GetcanHit(){
							return canHit;
							}


                                             }
