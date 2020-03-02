using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroi : MonoBehaviour {
	public string n;
	public GameObject cubo;
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnCollisionEnter(Collision col){
		if (col.gameObject.name!=null) {
			Destroy (gameObject);
			Instantiate (cubo, transform.position, Quaternion.Euler (0, 0, 0));
		}
	}
}
