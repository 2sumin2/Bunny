using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class onCollision_Crank : MonoBehaviour
{
    // Start is called before the first frame update
    public string targetObjectName; // 목표 오브젝트 이름 : Inspector에 지정
    public string transitionObjectName;
    public string crankUp = ""; // 보통 애니메이션 ：Inspector에 지정
    public string crankDown = "";   // 다음 애니메이션 ：Inspector에 지정
    public float speed = 1;

    bool up = false;
    bool fix = false;
    Rigidbody2D rbody;
    GameObject transitionObject;
    void Start()// 처음에 시행한다
    {
        // 중력을 0으로 하고, 충돌 시에 회전시키지 않는다 
        rbody = GetComponent<Rigidbody2D>();
        rbody.gravityScale = 0;
        rbody.constraints = RigidbodyConstraints2D.FreezeRotation | RigidbodyConstraints2D.FreezePositionX;

        transitionObject = GameObject.Find(transitionObjectName);
    }
    void OnCollisionEnter2D(Collision2D collision)// 충돌했을 때
    {
        // 만약 충돌한 것의 이름이 목표 오브젝트면
        if (collision.gameObject.name == targetObjectName)
        {
            up = !up;
        }
        if (collision.gameObject.name == "Square (1)")
        {
            up = false;
            fix = true;
        }
    }
    void FixedUpdate()
    {
        if (up && !fix)
        {
            Animator animator = this.GetComponent<Animator>();
            animator.Play(crankUp);
            transitionObject.transform.Translate(0, speed / 50, 0);
            //this.transform.Translate(0, speed / 50, 0);
        }
        else if (!up)
        {
            //transitionObject.transform.Translate(0, 0, 0);
            Animator animator = this.GetComponent<Animator>();
            animator.Play(crankDown);
        }
    }
}
