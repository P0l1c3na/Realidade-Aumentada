using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Texto2 : MonoBehaviour {

	public GameObject t;
	public string delta;string tt, vm;
	// Use this for initialization
	void Start () {
		t.GetComponent<TextMesh> ().text = "Vm = "+delta+"S / "+delta+"t";
	}

	// Update is called once per frame
	void Update () {
		if(moveCubo1.cont==9){
			vm = string.Format ("{0:####}", 900 / Texto1.time);
			tt = string.Format ("{0:####}", Texto1.time);
			t.GetComponent<TextMesh> ().text = "Vm = 900 / "+tt+" = "+vm+"km/h";
		}
	}
}
