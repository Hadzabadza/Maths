using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CameraMovement : MonoBehaviour {

	public Transform focusObject;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.position=new Vector3(focusObject.position.x,transform.position.y,transform.position.z);
		if (Input.GetAxis ("Cancel") != 0)
			Application.Quit ();
		if (Input.GetAxis ("Jump") != 0)
			SceneManager.LoadScene ("PortScene");
	}
}
