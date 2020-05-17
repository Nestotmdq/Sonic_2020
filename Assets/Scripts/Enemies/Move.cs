using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour {

	public float velocity = 2f;
	private Rigidbody2D rb;
	void Start () {
		rb = GetComponent<Rigidbody2D>();
		rb.velocity = Vector2.left * velocity;

	}
}
