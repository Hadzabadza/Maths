using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

	public Rigidbody2D rb;
	public float forceMod=2.0f;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void Update () {
		rb.AddForce (new Vector2(Input.GetAxis ("Horizontal")*forceMod,0.0f));
		if (rb.velocity.x < 0.0f)
			gameObject.GetComponent<SpriteRenderer> ().flipX = true;
		else
			gameObject.GetComponent<SpriteRenderer> ().flipX=false;
	}
}
