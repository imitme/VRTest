using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class AutoDoor : MonoBehaviour {

    public GameObject leftDoor;
    public GameObject rightDoor;

    private float originalLeftDoorX;
    private float originalRightDoorX;

    void Start () {
        originalLeftDoorX = leftDoor.transform.position.x;
        originalRightDoorX = rightDoor.transform.position.x;
	}
    void CloseDoor()
    {
        rightDoor.transform.DOLocalMoveX(originalRightDoorX, 1f);
        leftDoor.transform.DOLocalMoveX(originalLeftDoorX +1f, 1f);

//        Vector3 rPos = new Vector3(originalRightDoorX, 0f, 0f);
//        Vector3 lPos = new Vector3(originalLeftDoorX, 0f, 0f);
//        rightDoor.transform.DOMove(rPos, 1f);
//        leftDoor.transform.DOMove(lPos , 1f);

        //월드좌표기준
    //    rightDoor.transform.DOMoveX(originalRightDoorX, 1f);
      //  leftDoor.transform.DOMoveX(originalLeftDoorX, 1f);

    }
    void OpenDoor()
    {
        rightDoor.transform.DOLocalMoveX(originalRightDoorX - 0.5f, 1f);
        leftDoor.transform.DOLocalMoveX(originalLeftDoorX + 1.5f, 1f);

        //Vector3 rPos = new Vector3(originalRightDoorX - 1.5f, 0f, 0f);
        //Vector3 lPos = new Vector3(originalLeftDoorX + 1.5f, 0f, 0f);
        //rightDoor.transform.DOMove(rPos, 1f);
        //leftDoor.transform.DOMove(lPos, 1f);

        //월드좌표기준
        //        rightDoor.transform.DOMoveX(originalRightDoorX - 1.2f, 1f);
        //      leftDoor.transform.DOMoveX(originalLeftDoorX + 1.2f, 1f);

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Open");
            OpenDoor();
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Close");
            CloseDoor();
        }
    }
}
