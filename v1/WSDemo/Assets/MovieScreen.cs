using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class MovieScreen : Interactables
{

    public int m_MinIndex, m_MaxIndex;
    public int m_CurrentMeshId = 0;

    public VideoPlayer videoPlayer;
    public bool hasWatched;

    private void Start()
    {
        base.item.rollableItem = true;
        base.item.grabbable = false;

        hasWatched = false;

    }
    public override void ItemInteract()
    {
        base.ItemInteract();
        hasWatched = true;
        if (m_InteractBlockName != "")
        {
            UIManager.m_Instance.m_Flowchart.ExecuteBlock(m_InteractBlockName);
        }


        if (videoPlayer.isPlaying)
            PauseVideo();
        else
            PlayVideo();

    }
    public override void ItemRoll()
    {
        base.ItemRoll();
        if (m_RolledBlockName != "")
        {
            UIManager.m_Instance.m_Flowchart.ExecuteBlock(m_RolledBlockName);
        }
    }

    public override void RollCheck()
    {
        base.RollCheck();

        if (m_LeftItemBlock != "")
        {
            UIManager.m_Instance.m_Flowchart.ExecuteBlock(m_LeftItemBlock);
        }

    }

    public void PlayVideo()
    {
        videoPlayer.Play();
    }

    public void PauseVideo()
    {
        videoPlayer.Pause();
    }

}
