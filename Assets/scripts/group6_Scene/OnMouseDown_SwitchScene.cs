using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;  // 씬 전환에 필요 

// 터치하면 씬을 전환한다 
public class OnMouseDown_SwitchScene : MonoBehaviour
{

    public string sceneName;  // 씬 이름：Inspector에 지정
    int count = 0;
    int maxCount = 0;
    bool setcount = false;

    void OnMouseDown()
    { // 터치하면
        // 씬을 전환한다 
        SoundManager.instance.PlayClickSound();
        maxCount = 50;
        setcount = true;
    }

    void Update()
    {
        if (setcount)
        {
            count += 1;
            if (count == maxCount)
            {
                SceneManager.LoadScene(sceneName);
            }
        }

    }
}
