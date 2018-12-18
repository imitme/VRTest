using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoMove : MonoBehaviour {

    public float speed = 5.0f;
    public static bool isStopped = false;
    private Transform tr;
    private Transform camTr;
    private CharacterController cc;

	void Start () {
        camTr = Camera.main.GetComponent<Transform>();
        cc = GetComponent<CharacterController>();
	}
	
	void Update () {
        //항상가는 게 아니라 멈추면, 빠져나오게!
        if (isStopped) return;
        //카메라 바라보는 방향으로 캐릭터 move
        Vector3 direction = camTr.TransformDirection(Vector3.forward);
        cc.SimpleMove(direction * speed);
	}

}
