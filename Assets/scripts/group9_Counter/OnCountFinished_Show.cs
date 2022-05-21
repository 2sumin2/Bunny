using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 카운터가 최종값이면 표시한다 
public class OnCountFinished_Show : MonoBehaviour
{
    public string life3;  // 표시 오브젝트 이름：Inspector에 지정
    public string life2;
    public string life1;
    public string life0;

    GameObject showObjectLife3;
    GameObject showObjectLife2;
    GameObject showObjectLife1;
    GameObject showObjectLife0;

    void Start() // 처음에 시행한다 
    {
        // 지우기 전에 표시 오브젝트를 기억해 둔다 
        showObjectLife3 = GameObject.Find(life3);
        showObjectLife2 = GameObject.Find(life2);
        showObjectLife1 = GameObject.Find(life1);
        showObjectLife0 = GameObject.Find(life0);

        showObjectLife3.SetActive(false); // 지운다
        showObjectLife2.SetActive(false);
        showObjectLife1.SetActive(false);
        showObjectLife0.SetActive(false);
    }

    void FixedUpdate() // 계속 시행한다(일정 시간마다)
    {
        // 카운터가 최종값이 되면 
        if (GameCounter.value == 0)
        {
            showObjectLife3.SetActive(true); // 지웠던 것을 표시한다 
            showObjectLife2.SetActive(false);
            showObjectLife1.SetActive(false);
            showObjectLife0.SetActive(false);
        }
        if (GameCounter.value == 1)
        {
            showObjectLife3.SetActive(false); // 지웠던 것을 표시한다 
            showObjectLife2.SetActive(true);
            showObjectLife1.SetActive(false);
            showObjectLife0.SetActive(false);
        }
        if (GameCounter.value == 2)
        {
            showObjectLife3.SetActive(false); // 지웠던 것을 표시한다 
            showObjectLife2.SetActive(false);
            showObjectLife1.SetActive(true);
            showObjectLife0.SetActive(false);
        }
        if (GameCounter.value == 3)
        {
            showObjectLife3.SetActive(false); // 지웠던 것을 표시한다 
            showObjectLife2.SetActive(false);
            showObjectLife1.SetActive(false);
            showObjectLife0.SetActive(true);
        }
    }
}
