using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndingSceneTransform : MonoBehaviour
{

    public float waitTime = 2f;
    public float t;
    // Start is called before the first frame update
    void Start()
    {
        t = 0;
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

            SceneTransform.m_Instance.LoadEndLevel();
        }
    }
}
