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
        }
    }

    public void OnClickItemButton()
    {
        Debug.Log("###  Click  ###");
    }
}
