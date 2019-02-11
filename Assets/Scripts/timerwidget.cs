using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class timerwidget : MonoBehaviour
{
    public timerWidgetTypes timerType;
    public timekeeper timekeeper;
    public Text timeText;

    void Update()
    {
        switch (timerType)
        {
            case timerWidgetTypes.gameTimer:
                timeText.text = Mathf.Floor(timekeeper.gameTime / 60 ).ToString("00")  + ":" + Mathf.FloorToInt(timekeeper.gameTime % 60).ToString("00");
                break;

            case timerWidgetTypes.topTimer:
                timeText.text = Mathf.Floor(timekeeper.topTime / 60 ).ToString("00")  + ":" + Mathf.FloorToInt(timekeeper.topTime % 60).ToString("00");
                break;

            default:
                break;
        }
    }
}

public enum timerWidgetTypes
{
    gameTimer,
    topTimer
}
