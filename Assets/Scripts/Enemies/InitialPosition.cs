using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InitialPosition : MonoBehaviour {

	
	void Start () {
		

		gameObject.GetComponent<Transform>().position = new Vector3(-100,50,0);
	}
	
	
	}

