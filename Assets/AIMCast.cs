using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AIMCast : MonoBehaviour {
    public float dist = 10.0f;
    public AIM aim;
    public AIMCircle aimCircle;

    private Transform tr;
    private Ray ray;
    private RaycastHit hit;
    private GameObject prevObj;
    private GameObject currObj;

	void Start () {
        tr = GetComponent<Transform>();
	}
	
	void Update () {
        ray = new Ray(tr.position, tr.forward * dist);
        //if(Physics.Raycast(ray, out hit, 1 << 9 | 1 << 10))
        if (Physics.Raycast(ray, out hit, dist, 1 << 9 | 1 << 10))
        {
            AutoMove.isStopped = true;
            aim.isGaze = true;
            aimCircle.isGaze = true;
        }
        else
        {
            AutoMove.isStopped = false;
            aim.isGaze = false;
            aimCircle.isGaze = false;
        }
		
	}
}
