using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bubbledestroyzone : MonoBehaviour
{
    public GameObject popPrefab;

    void OnTriggerEnter2D (Collider2D col)
    {
        if (col.tag == "bubble")
        {
            Instantiate(popPrefab, col.transform.position, col.transform.rotation);
            Destroy(col.gameObject);
        }
    }
}
