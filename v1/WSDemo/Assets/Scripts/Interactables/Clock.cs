 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clock : Interactables
{
    static public Clock m_Instance;
    public int m_Hour = 8;
    public int m_MaxHour = 10;
    public int m_MinHour = 7;
    public Collider m_Bolck; 

    private void Awake()
    {
        m_Instance = this;
    }
    private void Start()
    {
        m_Bolck.enabled = true;
    }
    public override void ItemRoll()
    {
        base.ItemRoll();

        m_Hour = m_RollResult;
        UIManager.m_Instance.m_Flowchart.SetIntegerVariable("TimeH", m_Hour);
    }


    public override void RollCheck()
    {
        base.RollCheck();
        if (m_Hour > 8)
        {
            LateforTrain();
        }else if (m_Hour > 7)
        {
            HurryforTrain();
        }
        else
        {
            EarlyforTrain();
        }
        UIManager.m_Instance.m_Flowchart.SetIntegerVariable("TimeH", m_Hour);
        // 分支，多种可能
        UIManager.m_Instance.m_Flowchart.ExecuteBlock(m_LeftItemBlock);
        m_Bolck.enabled = false;
    }

    public override void ItemCollect()
    {
        base.ItemCollect();
        
    }
    public override void ItemInteract()
    {
        base.ItemInteract();
        UIManager.m_Instance.m_Flowchart.ExecuteBlock(m_InteractBlockName);

    }

    // Clock ROLL Results
    public void LateforTrain()
    {
        Debug.Log(m_Hour+": You know it's too late to catch the train, but you still decide to do it anyway, only need to wait longer.");
    }

    public void EarlyforTrain()
    {
        Debug.Log(m_Hour+": You made it! Just walk there.");
    }

    public void HurryforTrain()
    {
        Debug.Log(m_Hour+": You have to run very fast, or you might get caught between the doors.");
    }
}
