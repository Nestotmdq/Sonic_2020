using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControler : MonoBehaviour {

	public GameObject jumpSound;
	public float fuerza;
	public float fuerzaSalto;
	bool canJump;


	void Start(){

	//	gameObject.GetComponent<Animator>().SetBool("caida",false);



	}

	
	private void FixedUpdate () {
		
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

		                                                	gameObject.GetComponent<Animator>().SetBool("moving",false);
															}

		if(Input.GetKey("left") && Input.GetKeyDown("up")){
															runnerjump();
                            					    		}
		if(Input.GetKey("right") && Input.GetKeyDown("up")){
															runnerjump();
		                                                   }													

	}
	private void left(){

		gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(fuerza * -1 * Time.deltaTime,0));
		gameObject.GetComponent<SpriteRenderer>().flipX = true;
		gameObject.GetComponent<Animator>().SetBool("moving",true);
	}
	private void right(){


		
		gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(fuerza * Time.deltaTime,0));
		gameObject.GetComponent<SpriteRenderer>().flipX = false;
		gameObject.GetComponent<Animator>().SetBool("moving",true);
			


	}

	private void runnerjump(){

                      
                            gameObject.GetComponent<Animator>().SetBool("movjump",true);
						    up(50f);
					      


	}
	private void up(float fuerza){

	                  if(canJump == true){
                                          Instantiate(jumpSound);
	                    				  }

					  canJump = false;
					  gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0,fuerza));
					  gameObject.GetComponent<Animator>().SetBool("jump",true);
					  
	}
	
	void OnCollisionEnter2D(Collision2D coll)
	{
	 if(coll.transform.tag == "ground"){

		 								canJump = true;
										gameObject.GetComponent<Animator>().SetBool("jump",false);
										gameObject.GetComponent<Animator>().SetBool("movjump",false);
										gameObject.GetComponent<Animator>().SetBool("caida",false);

	 }

	}

	





}
