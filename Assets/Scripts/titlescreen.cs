using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class titlescreen : MonoBehaviour, IScreen
{
    public gameplaymanager gameplayManager;

    public void Show()
    {
        this.gameObject.SetActive(true);
    }

    public void Hide()
    {
        this.gameObject.SetActive(false);   
    }

    public void Click()
    {
        gameplayManager.ChangeState(GameplayState.Tutorial);
    }
}
