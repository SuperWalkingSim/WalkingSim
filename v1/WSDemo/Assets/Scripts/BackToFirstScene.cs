using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackToFirstScene : MonoBehaviour
{
    float waitTime = 10;
    float t;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (t < waitTime)
        {
            t += Time.deltaTime;
        }
        else
        {
            t = waitTime;

#if UNITY_EDITOR

                UnityEditor.EditorApplication.isPlaying = false;

#else

                Application.Quit();

#endif
        }
    }
}
