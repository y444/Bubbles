using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gameplaymanager : MonoBehaviour
{
    public GameObject[] drops;
    public Text timertext;
    public bool gameIsOn;
    public float gametime;
    
    // Start is called before the first frame update
    void Start()
    {
        gameIsOn = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (gameIsOn)
        {
            gametime += Time.deltaTime;
            timertext.text = Mathf.Floor(gametime / 60 ).ToString("00")  + ":" + Mathf.FloorToInt(gametime % 60).ToString("00");
        }
    }

    public bool IsDropTime()
    {
        // Check if it's time to drop
        
        return false;
    }
    
    public void Drop()
    {
        // Check if it is time to drop
        // Select a yet undropped object from the list of droppable objects
        // If there's no such objects, reset the list and select a random droppable objects
    }

    public void InitGame()
    {
        // Read prefs
        // Display and initialize title screen
    }

    public void StartTutorial()
    {
        // Display tutorial screen
        // Conduct tutorial
    }
    
    public void StartGame()
    {
        // Set game on flag
        // Hide the title screen
        // Display and initialize HUD
        // Start timer
    }

    public void EndGame()
    {
        // Drop game on flag
        // Write prefs
        // Hide and reset HUD
        // Show end game screen and select it's type
    }
}
