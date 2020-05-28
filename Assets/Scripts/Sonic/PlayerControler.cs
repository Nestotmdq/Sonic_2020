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
	PolygonCollider2D bc;
	
	void Start(){
		
		playerControler = this;
		an = gameObject.GetComponent<Animator>();
		rb = gameObject.GetComponent<Rigidbody2D>();
		sr = gameObject.GetComponent<SpriteRenderer>();
		bc = gameObject.GetComponent<PolygonCollider2D>();
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
                        rb.AddForce(new Vector2(0,110f * Time.deltaTime));
		                sr.flipX = true;
		                an.SetBool("moving",true);
                      	}
	private void right(){
		rb.AddForce(new Vector2(fuerza * Time.deltaTime,0));
		rb.AddForce(new Vector2(0,110f * Time.deltaTime));
		sr.flipX = false;
		an.SetBool("moving",true);
	}
	private void runnerjump(){
                             an.SetBool("movjump",true);
						     up(20f);
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
											 				 
											 }
											  	

	 void OnTriggerEnter2D(Collider2D other) {
			if(other.transform.tag == "phanton"){
                if(canJump == true){
                    Instantiate(soundHit);
                      keyActive = false;
                      an.SetBool("inertia",true);
		              an.SetBool("wakeup",false);
		              an.SetBool("caida",true);
					  StartCoroutine("Wait");
					  rb.AddForce(new Vector2(-200f,0));
					  rb.AddForce(new Vector2(0,400f));
				}
				
			}
			if(other.transform.tag == "nosalta"){
				canJump = false;
			}
	}
    IEnumerator Wait(){
					   Debug.Log("Entrando en wait");
                       yield return new WaitForSeconds(2);
                       sr.enabled = false;
					//   rb.AddForce(new Vector2(0,700f));
					   rb.AddForce(new Vector2(-150f,0));
					  // sr.enabled = true;
	                                  }


    public bool GetcanJump(){
	                        return canJump;
                            }
	public bool GetcanHit(){
							return canHit;
							}


                                             }
