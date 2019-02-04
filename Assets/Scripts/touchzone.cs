using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class touchzone : MonoBehaviour
{
    
    public GameObject bubblePrefab;
    public GameObject bubbleHolder;
    public bubblecounter bubbleCounter;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDown()
    {
        if (bubbleCounter.bubblesLeft > 0)
        {
        GameObject newBubble = Instantiate(bubblePrefab);
        newBubble.transform.parent = bubbleHolder.transform;
        newBubble.transform.position = new Vector3(Camera.main.ScreenToWorldPoint(Input.mousePosition).x, Camera.main.ScreenToWorldPoint(Input.mousePosition).y,0);
        newBubble.GetComponent<bubble>().randomIndex = UnityEngine.Random.Range(0,100);
        }   
    }
}
