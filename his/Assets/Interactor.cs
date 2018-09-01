using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactor : MonoBehaviour {

	public float interactDistanceSqrd=32.0f;
	public Transform player;
	public string inputTrigger = "Interact";
	public Color persistantColor;
	public float phase=0.0f;

	void Start () {
		persistantColor = new Color (1.0f, 1.0f, 1.0f);
	}

	// Update is called once per frame
	void Update () {
		gameObject.GetComponent<SpriteRenderer> ().color = new Color (Mathf.Abs(Mathf.Cos(phase)), persistantColor.g, persistantColor.b);
		if (player.distSqrd2D (transform) < interactDistanceSqrd) {
			phase += Time.deltaTime*2;
			if (phase > 3.14f)
				phase = 0.0f;
			if (Input.GetAxis (inputTrigger) > 0)
				Debug.Log ("Asked!");
		} else {
			if (phase > 0.03f)
				phase -= 0.03f;
			else
				phase = 0.0f;
		}
	}
}
