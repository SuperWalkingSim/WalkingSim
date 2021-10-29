using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIMoveUp : MonoBehaviour
{
    float speed = .5f;
    float waitTime = 5f;
    float t;

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

                transform.position += new Vector3(0, speed, 0);
            }

        //t += Time.deltaTime;
        

        //transform.position += new Vector3(0, speed, 0);



    }
}
