using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour {

	//Get the gameObject LoserCanvas
	public GameObject LoserCanvas;

	// Use this for initialization
	void Start () {
		Time.timeScale = 1;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void YouLose() {
		Time.timeScale = 0;
		LoserCanvas.SetActive (true);
	}

	public void Restart() {
		SceneManager.LoadScene (0);
	}	
}
