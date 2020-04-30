using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CaidaVacio : MonoBehaviour {

	
		
	
	
	void OnCollisionEnter2D(Collision2D other)
	{
		
	
		if(other.transform.tag == "vacio"){
			Debug.Log("me caì al vacio");
		}

	}
		
	}

