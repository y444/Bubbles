using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bubbledestroyzone : MonoBehaviour
{
    void OnTriggerEnter2D (Collider2D col)
    {
        if (col.tag == "bubble")
        {
            Destroy(col.gameObject);
        }
    }
}
