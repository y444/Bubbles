using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rockbottomzone : MonoBehaviour
{
    public timekeeper timekeeper;
    public GameObject sandSplashPrefab;
    public gameplaymanager gameplayManager;
    public soundplayer soundPlayer;
    public AudioSource sound;

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "drop")
        {
            soundPlayer.Play(sound);

            if (gameplayManager.gameplayState == GameplayState.Gameplay)
            {
                gameplayManager.ChangeState(GameplayState.GameEnd);
            }
            float splashY = -3f;
            float splashX = col.transform.position.x;
            Vector3 splashPosition = new Vector3(splashX, splashY, col.transform.position.z - 5f);
            Instantiate(sandSplashPrefab, splashPosition, new Quaternion());
        }

    }
}
