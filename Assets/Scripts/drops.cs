using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class drops : MonoBehaviour
{
    public GameObject[] dropPrefabs;
    public float underwaterSlowdown;
    public float underwaterDrag;
    public float startHeight;
    public GameObject splashPrefab;
    public timekeeper timekeeper;
    public float[] dropTime;
    public int nextDrop;
    public gameplaymanager gameplayManager;
    public soundplayer soundPlayer;
    public AudioSource[] splashSounds;

    void Update()
    {
        if (gameplayManager.gameplayState == GameplayState.Gameplay)
        {
            if (nextDrop < dropTime.Length)
            {
                if (timekeeper.gameTime > dropTime[nextDrop])
                {
                    Drop(nextDrop);
                    nextDrop++;
                }
            }
        }
    }

    void Drop(int dropIndex)
    {
        float minx = dropPrefabs[dropIndex].GetComponent<drop>().minLeftPosition;
        float maxx = dropPrefabs[dropIndex].GetComponent<drop>().maxRightPosition;
        float x = UnityEngine.Random.Range(minx, maxx);
        float y = startHeight;
        float rz = UnityEngine.Random.Range(0f, 365f);
        GameObject drop = Instantiate(dropPrefabs[dropIndex]);
        drop.transform.parent = transform;
        drop.transform.position = new Vector3(x, y, 0);
        drop.transform.rotation = Quaternion.Euler(new Vector3(0, 0, rz));
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "drop")
        {
            col.GetComponent<Rigidbody2D>().velocity = new Vector2(col.GetComponent<Rigidbody2D>().velocity.x, col.GetComponent<Rigidbody2D>().velocity.y * underwaterSlowdown);
            col.GetComponent<Rigidbody2D>().drag = underwaterDrag;

            //fuck yeah magic numbers!!11S
            float splashY = 4f;
            float splashX = col.transform.position.x;
            Vector3 splashPosition = new Vector3(splashX, splashY, col.transform.position.z);
            Instantiate(splashPrefab, splashPosition, new Quaternion());

            soundPlayer.Shuffle(splashSounds);
        }
    }

    public void DestroyVisibleDrops()
    {
        GameObject[] drops = GameObject.FindGameObjectsWithTag("drop");
        foreach (GameObject drop in drops)
        {
            Destroy(drop);
        }
    }
}