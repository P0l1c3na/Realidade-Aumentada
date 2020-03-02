using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveCubo1 : MonoBehaviour {
	public GameObject []pO;
	public Vector3[] pT = new Vector3[9];
	public static int cont=-1;
	public float v, l;
	// Use this for initialization
	void Start () {
		for (int i = 0; i < 9; i++) {
			pT [i] = pO [i].transform.position;
		}
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Space)|| Input.touchCount>0) {
			cont = 0;
			transform.position = pT [cont];
		}
		if (cont == 0) {
			if (Time.time > 2) {
				cont++;
			}
		} else if (cont == 1) {
			transform.position = Vector3.Lerp (transform.position, pT [cont],v* Time.deltaTime);
			if (transform.position.x >= pT [cont].x - l) {
				cont++;
			}
		} else if (cont == 2) {
			transform.position = Vector3.Lerp (transform.position, pT [cont],v* Time.deltaTime);
			if (transform.position.x >= pT [cont].x - l) {
				cont++;
			}
		} else if (cont == 3) {
			transform.position = Vector3.Lerp (transform.position, pT [cont], v*Time.deltaTime);
			if (transform.position.x >= pT [cont].x - l) {
				cont++;
			}
		} else if (cont == 4) {
			transform.position = Vector3.Lerp (transform.position, pT [cont],v* Time.deltaTime);
			if (transform.position.x >= pT [cont].x - l) {
				cont++;
			}
		} else if (cont == 5) {
			transform.position = Vector3.Lerp (transform.position, pT [cont], v*Time.deltaTime);
			if (transform.position.x >= pT [cont].x - l) {
				cont++;
			}
		} else if (cont == 6) {
			transform.position = Vector3.Lerp (transform.position, pT [cont], v*Time.deltaTime);
			if (transform.position.x >= pT [cont].x - l) {
				cont++;
			}
		} else if (cont == 7) {
			transform.position = Vector3.Lerp (transform.position, pT [cont],v* Time.deltaTime);
			if (transform.position.x >= pT [cont].x - l) {
				cont++;
			}
		} else if (cont == 8) {
			transform.position = Vector3.Lerp (transform.position, pT [cont],v* Time.deltaTime);
			if (transform.position.x >= pT [cont].x - l) {
				cont++;
			}
		}
	}
}
