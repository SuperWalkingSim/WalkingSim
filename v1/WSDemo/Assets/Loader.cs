using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Loader
{
    public enum Scene
    {
        GameScene=0,
    }
    public void Load(Scene scene)
    {
        SceneManager.LoadScene(scene.ToString());
    }

    
}
