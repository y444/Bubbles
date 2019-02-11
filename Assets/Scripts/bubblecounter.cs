using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class bubblecounter : MonoBehaviour
{
    //I HAVE NO IDEA WHAT'S GOING ON HERE ANYMORE SORRY
    
    public int maxBubbles;
    public GameObject bubbleMarkerPrefab;
    public int activeBubbles;
    public GameObject[] bubbleMarkers;
    public int bubblesLeft;
    public float markerDownscale;
    public Sprite normalSprite;
    public Sprite usedSprite;
    
    // Start is called before the first frame update
    void Start()
    {
        bubbleMarkers = new GameObject[maxBubbles];

        for (int i = 0; i < maxBubbles; i++ )
        {
           bubbleMarkers[i] = Instantiate(bubbleMarkerPrefab);
           bubbleMarkers[i].transform.SetParent(this.transform, false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        activeBubbles = GameObject.FindGameObjectsWithTag("bubble").Length;
        bubblesLeft = maxBubbles - activeBubbles;
        for (int i = 0; i < maxBubbles; i++)
        {
            if (i < activeBubbles)
            {
                bubbleMarkers[i].transform.localScale = new Vector3(markerDownscale,markerDownscale,1);
                bubbleMarkers[i].GetComponent<Image>().sprite = usedSprite;
            }
            else
            {
                bubbleMarkers[i].transform.localScale = new Vector3(1,1,1);
                bubbleMarkers[i].GetComponent<Image>().sprite = normalSprite;
            }
        }

    }
}
