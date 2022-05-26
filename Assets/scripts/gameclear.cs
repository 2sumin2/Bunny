using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gameclear : MonoBehaviour
{
    public string skipAnime = "";
    public string idleAnime = "";
    public string showObjectName;
    public string sceneName;
    int count = 0;

    Rigidbody2D rbody;
    GameObject showObject;

    void Start()
    { // 처음에 시행한다
      // 중력을 0으로 해서 충돌 시에 회전시키지 않는다
        rbody = GetComponent<Rigidbody2D>();
        rbody.gravityScale = 0;
        rbody.constraints = RigidbodyConstraints2D.FreezeRotation;

        showObject = GameObject.Find(showObjectName);
        showObject.SetActive(false);
    }

    void Update()
    { // 계속 시행한다

    }
    void FixedUpdate()
    {

        if (count < 200)
        {
            Animator animator = this.GetComponent<Animator>();
            animator.Play(skipAnime);
            count += 1;
            rbody.velocity = new Vector2(2, 0);
            if (count % 30 == 0)
            {
                SoundManager.instance.PlayStepSound();
            }
        }
        else if (count == 200)
        {
            Animator animator = this.GetComponent<Animator>();
            animator.Play(idleAnime);
            rbody.velocity = new Vector2(0, 0);
            showObject.SetActive(true);
            SoundManager.instance.PlayOwwSound();
            count += 1;
        }
        else if (count < 300)
        {
            count += 1;
        }
        else if (count == 300)
        {
            SceneManager.LoadScene(sceneName);
        }
    }
}

