using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rockbottomzone : MonoBehaviour
{
    //temp
    public timekeeper timekeeper;
    public GameObject sandSplashPrefab;
    
    void OnCollisionEnter2D (Collision2D col)
    {
        if (col.gameObject.tag == "drop")
        {
            //temp block
            timekeeper.timerOn = false;
            timekeeper.saveTopTime();
            
            
            float splashY = -3f;
            float splashX = col.transform.position.x;
            Vector3 splashPosition = new Vector3(splashX, splashY, col.transform.position.z - 5f);
            Instantiate(sandSplashPrefab, splashPosition, new Quaternion());
        }
    }
}
