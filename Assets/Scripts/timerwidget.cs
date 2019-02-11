using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class timerwidget : MonoBehaviour
{
    public timerWidgetTypes timerType;
    public timekeeper timekeeper;
    public Text timeText;
    public float initialTime;

    // Start is called before the first frame update
/*     void Start()
    {
        switch (timerType)
        {
            case timerWidgetTypes.gameTimer:
                initialTime = timekeeper.gameTime;
                break;

            case timerWidgetTypes.topTimer:
                initialTime = timekeeper.topTime;
                break;

            default:
                initialTime = 999;
                break;
        }
    } */

    // Update is called once per frame
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
                initialTime = 999;
                break;
        }
    }
}

public enum timerWidgetTypes
{
    gameTimer,
    topTimer
}
