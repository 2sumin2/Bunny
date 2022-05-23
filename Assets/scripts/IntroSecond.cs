using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class IntroSecond : MonoBehaviour
{
    public string skipAnime = "";
    public string idleAnime = "";
    public string hurtAnime = "";
    public string showObjectNameOne;
    public string showObjectNameTwo;
    public string showObjectNameThree;
    public string sceneName;
    int count = 0;

    Rigidbody2D rbody;
    GameObject showObjectOne;
    GameObject showObjectTwo;
    GameObject showObjectThree;

    void Start()
    { // 처음에 시행한다
      // 중력을 0으로 해서 충돌 시에 회전시키지 않는다
        rbody = GetComponent<Rigidbody2D>();
        rbody.gravityScale = 0;
        rbody.constraints = RigidbodyConstraints2D.FreezeRotation;

        showObjectOne = GameObject.Find(showObjectNameOne);
        showObjectOne.SetActive(false);

        showObjectTwo = GameObject.Find(showObjectNameTwo);
        showObjectTwo.SetActive(false);

        showObjectThree = GameObject.Find(showObjectNameThree);
        showObjectThree.SetActive(false);
    }

    void Update()
    { // 계속 시행한다

    }
    void FixedUpdate()
    {


        if (count < 250)
        {
            Animator animator = this.GetComponent<Animator>();
            animator.Play(skipAnime);
            rbody.velocity = new Vector2(2, 0);
            if (count % 30 == 0)
            {
                SoundManager.instance.PlayStepSound();
            }
        }
        else if (count == 278)
        {
            rbody.velocity = new Vector2(0, 0);
            Animator animator = this.GetComponent<Animator>();
            SoundManager.instance.PlayShockSound();
            animator.enabled = false;
            showObjectOne.SetActive(true);
        }
        else if (count == 300)
        {
            Animator animator = this.GetComponent<Animator>();
            animator.Play(hurtAnime);
            animator.enabled = true;
            showObjectOne.SetActive(false);
            showObjectTwo.SetActive(true);
        }
        else if (count == 310)
        {
            showObjectTwo.SetActive(false);
            showObjectThree.SetActive(true);
        }
        else if (count == 320)
        {
            showObjectTwo.SetActive(true);
            showObjectThree.SetActive(false);
        }
        else if (count == 330)
        {
            showObjectTwo.SetActive(false);
            showObjectThree.SetActive(true);
        }

        else if (count == 420)
        {
            SceneManager.LoadScene(sceneName);
        }

        if (count < 420)
        {
            count += 1;
        }
    }
}
