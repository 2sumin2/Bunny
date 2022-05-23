using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IntroThird : MonoBehaviour
{
    public string showObjectName;
    public string carrotName;
    public string skipAnime = "";
    public string idleAnime = "";
    int count = 0;
    Rigidbody2D rbody;
    GameObject showObject;
    GameObject carrot;

    void Start()
    { // 처음에 시행한다
      // 중력을 0으로 해서 충돌 시에 회전시키지 않는다
        rbody = GetComponent<Rigidbody2D>();
        rbody.gravityScale = 0;
        rbody.constraints = RigidbodyConstraints2D.FreezeRotation;

        showObject = GameObject.Find(showObjectName);
        showObject.SetActive(false);

        carrot = GameObject.Find(carrotName);

        Animator animator = this.GetComponent<Animator>();
        animator.Play(idleAnime);


    }

    void Update()
    { // 계속 시행한다

    }
    void FixedUpdate()
    {
        if (count == 10)
        {
            SoundManager.instance.PlayOwwSound();
        }
        if (count == 100)
        {
            Animator animator = this.GetComponent<Animator>();
            animator.Play(skipAnime);
            rbody.velocity = new Vector2(2, 0);
            carrot.SetActive(false);
        }
        if (count == 500)
        {
            showObject.SetActive(true);
            SoundManager.instance.PlayStartSound();
        }
        if (count >= 100 && count % 30 == 0)
        {
            SoundManager.instance.PlayStepSound();
        }
        if (count <= 500)
        {
            count += 1;
        }
    }
}
