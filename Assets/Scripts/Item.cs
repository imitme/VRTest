using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour {
    public GameObject canvasObj;   //
    private void Start()
    {
        canvasObj.SetActive(false);
    }

    public void OnPointEnter(bool isEnter)
    {
        if (isEnter)
        {
            canvasObj.SetActive(true);
            //AutoMove.isStopped = true;    //Aim 에서 처리중이다
            //Debug.Log("Enter");
        }
        else
        {
            //AutoMove.isStopped = false;   //Aim 에서 처리중이다
            //Debug.Log("Exit");
        }
    }
}
