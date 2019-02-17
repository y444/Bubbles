using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rockbottomzone : MonoBehaviour
{
    //temp
    public timekeeper timekeeper;
    public GameObject sandSplashPrefab;
    public gameplaymanager gameplayManager;
    
    void OnCollisionEnter2D (Collision2D col)
    {
        if (col.gameObject.tag == "drop")
        {
            //temp block - move to gameplay manager
            timekeeper.timerOn = false;
            timekeeper.saveTopTime();
            //end temp block
            
            gameplayManager.ChangeState(GameplayState.GameEnd);
            
            float splashY = -3f;
            float splashX = col.transform.position.x;
            Vector3 splashPosition = new Vector3(splashX, splashY, col.transform.position.z - 5f);
            Instantiate(sandSplashPrefab, splashPosition, new Quaternion());
        }
    }
}
