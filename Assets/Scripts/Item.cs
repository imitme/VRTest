using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour {

    public void OnPointEnter(bool isEnter)
    {
        if (isEnter)
        {
            Debug.Log("Enter");
        }
        else
        {
            Debug.Log("Exit");
        }
    }
}
