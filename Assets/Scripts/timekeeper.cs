using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class timekeeper : MonoBehaviour
{
    public bool timerOn;
    public float gameTime;
    public float topTime;

    void Update()
    {
        if (timerOn)
        {
            gameTime += Time.deltaTime;
            if (gameTime >= topTime)
            {
                topTime = gameTime;
            }
        }
    }

    void Reset()
    {
        gameTime = 0f;
    }
}
