using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class CollisionRings : MonoBehaviour {

		public GameObject soundTrap;
		public Text canvasText;
	
		private void OnCollisionEnter2D(Collision2D other) {

			Instantiate(soundTrap);
			DataBank.dataBank.SetRings();
			DataBank.dataBank.GetRings();
			canvasText.text = DataBank.dataBank.GetRings();
			Destroy(gameObject);

			
		}
	
	
	
		
	
	
	
		
	
}
