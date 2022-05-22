using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IntroThird : MonoBehaviour
{
    public string showObjectName;
    int count = 0;
    Rigidbody2D rbody;
    GameObject showObject;


    void Start()
    { // 처음에 시행한다
      // 중력을 0으로 해서 충돌 시에 회전시키지 않는다
        rbody = GetComponent<Rigidbody2D>();
        rbody.gravityScale = 0;
        rbody.constraints = RigidbodyConstraints2D.FreezeRotation;
        rbody.velocity = new Vector2(2, 0);

        showObject = GameObject.Find(showObjectName);
        showObject.SetActive(false);
    }

    void Update()
    { // 계속 시행한다

    }
    void FixedUpdate()
    {

        if (count == 400)
        {
            showObject.SetActive(true);
        }

        if (count < 400)
        {
            count += 1;
        }
    }
}
