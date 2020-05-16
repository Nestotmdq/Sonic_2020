using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollInfinito : MonoBehaviour {
	Material mt;
	public float paralax = 2f;
	Vector2  offset;
	Transform cam;

	
	void Start () {
		SpriteRenderer sp = GetComponent<SpriteRenderer>();
		mt = sp.material;
		cam = Camera.main.transform;
		offset = mt.mainTextureOffset;
	}
	
	
	void Update () {
		offset.x = cam.position.x / transform.localScale.x / paralax;
		offset.y = cam.position.y / transform.localScale.y / paralax;
		mt.mainTextureOffset = offset;
		
	}
}
