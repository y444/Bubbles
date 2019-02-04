using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gameplaymanager : MonoBehaviour
{
    public GameObject[] drops;
    public Text timertext;
    public bool gameOn;
    public float gametime;
    
    // Start is called before the first frame update
    void Start()
    {
        gameOn = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (gameOn)
        {
            gametime += Time.deltaTime;
            timertext.text = Mathf.Floor(gametime / 60 ).ToString("00")  + ":" + Mathf.FloorToInt(gametime % 60).ToString("00");
        }
    }

    public void SpawnDrop()
    {

    }

    public void StartGame()
    {

    }

    public void EndGame()
    {

    }
}
