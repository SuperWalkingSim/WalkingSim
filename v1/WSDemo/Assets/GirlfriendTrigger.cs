using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GirlfriendTrigger : MonoBehaviour
{
    public PlayerInteraction player;
    private bool firstMeet;
    public string m_DateBlock;

    private void Start()
    {
        firstMeet = false;
    }
    private void OnTriggerEnter(Collider other)
    {
        if(firstMeet == false)
        {
            player.ActivateGirlFriend();
            UIManager.m_Instance.m_Flowchart.ExecuteBlock(m_DateBlock);
        }
        firstMeet = true;
        
    }
}
