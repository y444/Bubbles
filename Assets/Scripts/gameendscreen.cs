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
    public soundplayer soundPlayer;
    public AudioSource winSound;
    public AudioSource loseSound;
    
    public void Show()
    {
        this.gameObject.SetActive(true);
        if (timeKeeper.isNewTopTime)
        {
            winBlock.SetActive(true);
            soundPlayer.Play(winSound);
        }
        else
        {
            loseBlock.SetActive(true);
            soundPlayer.Play(loseSound);
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
