using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class onCollision_Move : MonoBehaviour
{
    //public string targetObjectName;
    float vy = 0;

    // Start is called before the first frame update
    Rigidbody2D rbody;
    GameObject showObject;

    void Start()
    { // 처음에 시행한다
      // 중력을 0으로 해서 충돌 시에 회전시키지 않는다
        rbody = GetComponent<Rigidbody2D>();
        rbody.gravityScale = 0;
        rbody.constraints = RigidbodyConstraints2D.FreezeRotation | RigidbodyConstraints2D.FreezePositionX;
    }
    void OnTriggerStay2D(Collider2D collision)
    { // 발이 무언가에 닿으면 
        vy = -1;
    }
    void OnTriggerExit2D(Collider2D collision)
    { // 발에 아무 것도 닿지 않으면 
        vy = 0;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rbody.velocity = new Vector2(0, vy);
    }


}
