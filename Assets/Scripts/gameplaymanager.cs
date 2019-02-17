using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameplaymanager : MonoBehaviour
{
    public titlescreen titleScreen;
    public tutorialscreen tutorialScreen;
    public gameplayscreen gameplayScreen;
    public gameendscreen gameEndScreen;

    public GameplayState gameplayState;
    public timekeeper timekeeper;
    public drops drops;
    public bubbles bubbles;
    
    void Start()
    {
        ChangeState(GameplayState.Title);
    }

    void Update()
    {
        
    }

    public void ChangeState(GameplayState newState)
    {
        titleScreen.Hide();
        tutorialScreen.Hide();
        gameplayScreen.Hide();
        gameEndScreen.Hide();

        switch (newState)
        {
            case GameplayState.Title:
            titleScreen.Show();
            break;
            
            case GameplayState.Tutorial:
            tutorialScreen.Show();
            break;
            
            case GameplayState.Gameplay:
            gameplayScreen.Show();
            GameStart();
            break;
            
            case GameplayState.GameEnd:
            gameEndScreen.Show();
            GameEnd();
            break;
            
            default:
            break;

        }

        gameplayState = newState;
    }

    public void GameStart()
    {
        timekeeper.Reset();
        timekeeper.timerOn = true;
        timekeeper.topTime = timekeeper.getTopTime();
        timekeeper.isNewTopTime = false;
        drops.DestroyVisibleDrops();
        drops.nextDrop = 0;
        bubbles.DestroyVisibleBubbles();
        bubbles.EnableBubbling(true);
    }

    public void GameEnd()
    {
        timekeeper.timerOn = false;
        timekeeper.saveTopTime();
        bubbles.EnableBubbling(false);
    }
}

public enum GameplayState
{
    Title, Tutorial, Gameplay, GameEnd
}
