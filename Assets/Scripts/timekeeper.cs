using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class timekeeper : MonoBehaviour
{
    public bool timerOn;
    public float gameTime;
    public float topTime;
    public bool isNewTopTime;
    public gameplaymanager gameplayManager;

    void Update()
    {
        if (gameplayManager.gameplayState == GameplayState.Gameplay)
        {
            if (timerOn)
            {
                gameTime += Time.deltaTime;
            }
            if (gameTime > topTime)
            {
                topTime = gameTime;
                isNewTopTime = true;
            }
        }
    }

    public void Reset()
    {
        gameTime = 0f;
    }

    public void saveTopTime()
    {
        PlayerPrefs.SetFloat("top time", topTime);
    }

    public float getTopTime()
    {
        return PlayerPrefs.GetFloat("top time", 0f);
    }

}
