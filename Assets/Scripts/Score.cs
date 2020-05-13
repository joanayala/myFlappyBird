using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour {

	// Use this for initialization
	public GameObject PointsCanvas1;
	public GameObject PointsCanvas0;
	public static int score = 0;

	void Start () {
		score = 0;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	private void OnTriggerEnter2D(Collider2D collaider) {
		Debug.Log ("You've win one point");
		PointsCanvas1.SetActive (true);
		PointsCanvas0.SetActive (false);
	}
}
