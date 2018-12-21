using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AIMCircle : MonoBehaviour {
    public float fillDuration = 1;
    public bool isGaze = false;
    private Image circleImage;
    public bool IsFull
    {
        get //read Only property?
        {
            return circleImage.fillAmount >= 1 ? true : false;
        }

    }

	void Start () {
        circleImage = GetComponent<Image>();
        circleImage.fillAmount = 0; //처음에 눈에 안보이게 해주고
	}
	
	void Update () {
        if(isGaze)
        {
            if(circleImage.fillAmount < 1)
            {
                circleImage.fillAmount += Time.deltaTime / fillDuration;    //1보다 작으면 더해주고,
            }
        }
        else
        {
            circleImage.fillAmount = 0;     //눈이 떨어지면, 다시 0으로 초기화!
        }
		
	}
}
