using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 계속 카메라가 쫓아간다
public class Chase_Camera : MonoBehaviour
{
    public string targetObjectName = "";

    GameObject targetObject;
    void LateUpdate()// 계속 시행한다(여러 가지 처리의 마지막에)
    {
        targetObject = GameObject.Find(targetObjectName);
        Vector3 pos = targetObject.transform.position;
        pos.y = pos.y + 5;
        pos.x = pos.x - 8;
        this.transform.position = pos;


        //Vector3 pos = Camera.main.gameObject.transform.position;
        //pos.z = -2;
        //pos.y = pos.y + 4;
        //pos.x = pos.x - 8;
        //this.transform.position = pos;
    }
}
