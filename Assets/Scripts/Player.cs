using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

	public SceneController sceneController;

	private Rigidbody2D rb;
	public float speed = 1;
	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D> ();		
	}
	
	// Update is called once per frame
	void Update () {
		//GetMouseButtonDown => Touch
		if (Input.GetMouseButtonDown (0)) {
			rb.velocity = Vector2.up * speed;
		}
	}

	private void OnCollisionEnter2D(Collision2D collision) {
		sceneController.YouLose ();			
	}
}
