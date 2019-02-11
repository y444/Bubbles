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
}
