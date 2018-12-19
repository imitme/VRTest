using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;     //?? 캔버스 용? 캔버스 내 이벤트 전달 관련 코드들이 들어잇다.

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
        CheckGaze();
	}
    void CheckGaze()
    {
        //레이이용해서 이벤트 전달하기
        PointerEventData data = new PointerEventData(EventSystem.current);
        if(Physics.Raycast(ray, out hit, dist, 1<<9 | 1 << 10))
        {
            currObj = hit.collider.gameObject;  //히트된 오브젝트
            if(currObj != prevObj)      //히드된 오브젝트가 처음 바라봣을때 엔터 핸들러 ! 해서, 호출? 두번짼 이미 바라보는것이 들어가 있기에, 통과!
            {
                ExecuteEvents.Execute(currObj, data, ExecuteEvents.pointerEnterHandler);
                ExecuteEvents.Execute(currObj, data, ExecuteEvents.pointerExitHandler);
                prevObj = currObj;  //바라보는 것을을 넣었어,
            }
        }
        else
        {
            if(prevObj != null)
            {
                ExecuteEvents.Execute(prevObj, data, ExecuteEvents.pointerExitHandler);
                prevObj = null;
            }
        }
    }
}
