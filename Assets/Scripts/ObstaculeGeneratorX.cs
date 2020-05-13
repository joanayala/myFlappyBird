using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstaculeGeneratorX : MonoBehaviour {

	//Variables
	public float height; //altura [-height, height]
	public GameObject obstacule; //Obtener el objeto -> Obstáculos
	public float minTime = 0, maxTime = 1;

	// Use this for initialization
	void Start () {
		GameObject newObstacule = Instantiate (obstacule);
		newObstacule.transform.position = transform.position + new Vector3 (0, 0, 0);
		Destroy (gameObject, 7);
	}	

	// Update is called once per frame
	void Update () {
		if (minTime > maxTime) {
			GameObject newObstacule = Instantiate (obstacule);
			newObstacule.transform.position = transform.position +
				new Vector3 (0, Random.Range (-height, height), 0);
			Destroy (gameObject, 10);
			minTime = 0;
		} else {
			minTime += Time.deltaTime;
		}

	}
}
