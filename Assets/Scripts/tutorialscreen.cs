using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tutorialscreen : MonoBehaviour, IScreen
{
    public gameplaymanager gameplayManager;
    
    public void Show()
    {
        this.gameObject.SetActive(true);
    }

    public void Hide()
    {
        //I will show tutorial everytime anyway I guess, but let's keep in here just in case
        PlayerPrefs.SetInt("Tutorial Complete", 1);
        this.gameObject.SetActive(false);
    }

    public void Click()
    {
        gameplayManager.ChangeState(GameplayState.Gameplay);
    }
}
