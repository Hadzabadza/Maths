using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EyeFollow : MonoBehaviour {

	public RectTransform rt;
	public Vector3 origin;
	public float eyeWidth, eyeHeight;
	public float mouseRelX, mouseRelY;

	// Use this for initialization
	void Start () {
		rt = gameObject.GetComponent<RectTransform> ();
		origin = new Vector3 (GetComponent<RectTransform> ().position.x,GetComponent<RectTransform> ().position.y);
		eyeWidth = 5.0f;
		eyeHeight = 15.0f;
		if (origin.x > Screen.width/2)
			mouseRelX = origin.x/eyeWidth;
		else
			mouseRelX=(Screen.width-origin.x)/eyeWidth;
		if (origin.y > Screen.height/2)
			mouseRelY = origin.y/eyeHeight;
		else
			mouseRelY=(Screen.height-origin.y)/eyeHeight;
	}

	// Update is called once per frame
	void Update () {
		rt.position = new Vector3 ((Input.mousePosition.x - origin.x) / mouseRelX+origin.x, (Input.mousePosition.y - origin.y) / mouseRelY+origin.y);
	}
}
