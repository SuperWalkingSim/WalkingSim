using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneTransform : MonoBehaviour
{
    public Dice dice;
    public float rollTime=3f;
    public static SceneTransform m_Instance;
    private void Start()
    {
        
    }

    private void Awake()
    {
        m_Instance = this;
    }
    private void Update()
    {
    }
    public void LoadNextLevel()
    {
        Debug.Log("Load map");
        StartCoroutine(LoadStartLevel(SceneManager.GetActiveScene().buildIndex+1));
    }


    public void OnClickStartBt()
    {
        LoadNextLevel();
    }

    IEnumerator LoadStartLevel(int levelIndex)
    {
        dice.Roll();

        //yield on a new YieldInstruction that waits for 5 seconds.
        yield return new WaitForSeconds(rollTime);
        SceneManager.LoadScene(levelIndex);
    }


    public void LoadEndLevel()
    {
        Debug.Log("Load End");
        StartCoroutine(LoadEndingScene(SceneManager.GetActiveScene().buildIndex + 1));
    }

    IEnumerator LoadEndingScene(int levelIndex)
    {
        yield return new WaitForSeconds(rollTime);

        SceneManager.LoadScene(levelIndex);
    }
}
