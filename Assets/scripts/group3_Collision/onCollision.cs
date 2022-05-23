using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class onCollision : MonoBehaviour
{
    // Start is called before the first frame update
    public string targetObjectName; // 목표 오브젝트 이름 : Inspector에 지정
    public string audio;

    void OnCollisionEnter2D(Collision2D collision)// 충돌했을 때
    {
        // 만약 충돌한 것의 이르이 목표 오브젝트면 
        if (collision.gameObject.name == targetObjectName)
        {
            if (audio == "item")
            {
                SoundManager.instance.PlayItemSound();
            }

        }
    }
}
