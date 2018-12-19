using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyCanvas : MonoBehaviour {
    private Transform camTr;
    private Transform canvasTr;

	// Use this for initialization
	void Start () {
        camTr = Camera.main.transform;
        canvasTr = transform;
	}
	
	// Update is called once per frame
	void Update () {
        canvasTr.LookAt(camTr.position);
	}
}
