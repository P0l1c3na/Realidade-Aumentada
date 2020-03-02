using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;
public class instantiate2 : MonoBehaviour {
	public GameObject posicao, prefab;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Space)|| Input.touchCount>0 && DefaultTrackableEventHandler.identif==1) {
			Instantiate (prefab, posicao.transform.position, Quaternion.Euler (0, 0, 0));
		}
	}
}
