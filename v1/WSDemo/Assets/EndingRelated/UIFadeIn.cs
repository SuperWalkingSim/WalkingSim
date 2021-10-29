using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIFadeIn : MonoBehaviour
{
    float fadeInSpeed = .75f;
    

    // Start is called before the first frame update
    void Start()
    {
        GetComponent<CanvasGroup>().alpha = 0;
    }

    // Update is called once per frame
    void Update()
    {
        FadeIn(gameObject);
    }

    void FadeIn(GameObject go)
    {
        //Debug.Log("function called");
        //GameObject go = UI.transform.Find(name).gameObject;
        if (go.GetComponent<CanvasGroup>().alpha < 1)
        {
            go.GetComponent<CanvasGroup>().alpha += Time.deltaTime * fadeInSpeed;
        }
        else
        {
            go.GetComponent<CanvasGroup>().alpha = 1;
            return;
        }
    }
}
