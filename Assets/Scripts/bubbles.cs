using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bubbles : MonoBehaviour
{
    
    public GameObject bubblePrefab;
    public bubblecounter bubbleCounter;

    void OnMouseDown()
    {
        if (bubbleCounter.bubblesLeft > 0)
        {
        GameObject newBubble = Instantiate(bubblePrefab);
        newBubble.transform.parent = transform;
        newBubble.transform.position = new Vector3(Camera.main.ScreenToWorldPoint(Input.mousePosition).x, Camera.main.ScreenToWorldPoint(Input.mousePosition).y,0);
        newBubble.GetComponent<bubble>().randomIndex = UnityEngine.Random.Range(0,100);
        }   
    }

    public void DestroyVisibleBubbles()
    {
        GameObject[] bubbles = GameObject.FindGameObjectsWithTag("bubble");
        foreach (GameObject bubble in bubbles)
        {
            Destroy(bubble);
        }
    }

    public void EnableBubbling(bool enable)
    {
        if (enable)
        {
            GetComponent<BoxCollider2D>().enabled = true;
        }
        else
        {
            GetComponent<BoxCollider2D>().enabled = false;
        }
    }
}
