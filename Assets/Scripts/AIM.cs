using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;   //UI추가

public class AIM : MonoBehaviour {
    public Color gazeColor = Color.yellow;
    public bool isGaze = false;
    public float duration = 0.2f;   // 커지는 동안
    public float minSize = 0.4f;    // 작아질떄 사이즈    
    public float maxSize = 1.6f;    // 커질때 사이즈    

    private Color originalColor = new Color(1.0f, 1.0f, 1.0f, 1.0f); //특정 오브젝트 바라보고 있지 않으떄, 
    private Transform tr;       //애임 자신 저장 위치
    private Image aimImage;     //애임 소스 이미지 
    private float startTime;    //바라보기 시작할때, 그 시점 저장할 공간.
    
    
    // Use this for initialization
    void Start () {
        tr = GetComponent<Transform>();
        aimImage = GetComponent<Image>();
        startTime = Time.time;
        tr.localScale = Vector3.one * minSize;
        aimImage.color = originalColor;
	}
	
	// Update is called once per frame
	void Update () {
        if (isGaze)     //트루이면, 
        {   //에임 사이즈를 키운다!
            float t = (Time.time - startTime) / duration;
            tr.localScale = Vector3.one * Mathf.Lerp(minSize, maxSize,t);
            aimImage.color = gazeColor;
        }
        else
        {
            tr.localScale = Vector3.one * minSize;
            aimImage.color = originalColor;
            startTime = Time.time;
        }
	}
}
