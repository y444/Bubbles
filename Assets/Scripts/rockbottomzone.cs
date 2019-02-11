using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rockbottomzone : MonoBehaviour
{
    //temp
    public timekeeper timekeeper;
    
    void OnCollisionEnter2D (Collision2D col)
    {
        if (col.gameObject.tag == "drop")
        {
            //temp block
            timekeeper.timerOn = false;
            timekeeper.saveTopTime();
        }
    }
}
