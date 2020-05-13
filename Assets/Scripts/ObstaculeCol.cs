using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstaculeCol : MonoBehaviour {

	public float speed = 0;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame -> Loop
	void Update () {
		transform.position += Vector3.left * speed * Time.deltaTime;	
	}
}
