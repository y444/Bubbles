using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gameendscreen : MonoBehaviour, IScreen
{
    public gameplaymanager gameplayManager;
    public timekeeper timeKeeper;
    public GameObject winBlock;
    public GameObject loseBlock;
    
    public void Show()
    {
        this.gameObject.SetActive(true);
        if (timeKeeper.isNewTopTime)
        {
            winBlock.SetActive(true);
        }
        else
        {
            loseBlock.SetActive(true);
        }
    }

    public void Hide()
    {
        winBlock.SetActive(false);
        loseBlock.SetActive(false);
        this.gameObject.SetActive(false);
    }

    public void Click()
    {
        gameplayManager.ChangeState(GameplayState.Gameplay);
    }
}
