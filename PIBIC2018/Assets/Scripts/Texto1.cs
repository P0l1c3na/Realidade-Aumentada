using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Texto1 : MonoBehaviour {
	public GameObject t;
	public static double time =0.0;string tempo;
	public string delta;
	// Use this for initialization
	void Start () {
		t.GetComponent<TextMesh> ().text = delta+"t = t - to\n"+delta+"t = "+tempo;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Space)|| Input.touchCount>0) {
			time = 0;
		}
		if (moveCubo1.cont >= 0 && moveCubo1.cont!=9) {
			time += Time.deltaTime/2;
		}
		tempo = string.Format ("{0:####}", time);
		t.GetComponent<TextMesh> ().text = delta+"t = t - to\n"+delta+"t = "+tempo;
	}
}
