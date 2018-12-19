using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour {

    public void OnPointEnter(bool isEnter)
    {
        if (isEnter)
        {
            AutoMove.isStopped = true;
            //Debug.Log("Enter");
        }
        else
        {
            AutoMove.isStopped = false;
            //Debug.Log("Exit");
        }
    }
}
