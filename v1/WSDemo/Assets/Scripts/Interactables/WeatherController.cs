using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeatherController : MonoBehaviour
{
    [SerializeField] private Animator weatherAnimator;
    public bool weatherPopped = false;
    public string m_CallWeatherBlock;
    private void OnTriggerEnter(Collider other)
    {
        weatherAnimator.SetBool("IsOpen", true);
        weatherPopped = true;
        UIManager.m_Instance.m_Flowchart.ExecuteBlock(m_CallWeatherBlock);

    }

    public void HideWeather()
    {
        weatherAnimator.SetBool("IsOpen", false);
    }

    private void OnTriggerExit(Collider other)
    {
        if (weatherPopped == true)
        {
            HideWeather();
        }
    }
    void Start()
    {
    }
}
