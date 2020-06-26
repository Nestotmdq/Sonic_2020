using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerControler : MonoBehaviour {
	public Text RingCounter;
	public Text LifeCanvas;
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
	string tienerings;
	int tieneringsint;
	public Text canvasText;
	void Start(){
		
		RingCounter.color = Color.red;
		playerControler = this;
		an = gameObject.GetComponent<Animator>();
		rb = gameObject.GetComponent<Rigidbody2D>();
		sr = gameObject.GetComponent<SpriteRenderer>();
	//	bc = gameObject.GetComponent<PolygonCollider2D>();
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
					int ringstiene = int.Parse(DataBank.dataBank.GetRings());
                    if(ringstiene == 0){
						DataBank.dataBank.SetVidas(-1);
						LifeCanvas.text = DataBank.dataBank.GetVidas()+ "";
						if(DataBank.dataBank.GetVidas()==0){

														Over.show();
						}
					                   }
                    DataBank.dataBank.cerorings();
					RingCounter.color = Color.red; 
					canvasText.text = DataBank.dataBank.GetRings();
                    Instantiate(soundHit);
                    keyActive = false;
		            an.SetBool("wakeup",true);
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
					  
                       yield return new WaitForSeconds(3);
					   an.SetBool("wakeup",false);
					   keyActive = true;
					   rb.AddForce(new Vector2(-150f,0));
	                                  }
    public bool GetcanJump(){
	                        return canJump;
                            }
	public bool GetcanHit(){
							return canHit;
							}


                                             }
