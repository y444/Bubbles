using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class waterzone : MonoBehaviour
{
    public surfboard surfboardPrefab;
    public float underwaterSlowdown;
    public float underwaterDrag;
    // Start is called before the first frame update
    void Start()
    {
        float minx = surfboardPrefab.minStartRange;
        float maxx = surfboardPrefab.maxStartRange;
        float x = UnityEngine.Random.Range(minx, maxx);
        float y = surfboardPrefab.startHeight;
        float rz = UnityEngine.Random.Range(0f, 365f);
        surfboard surfboard = Instantiate(surfboardPrefab);
        surfboard.transform.position = new Vector3(x,y,0);
        surfboard.transform.rotation = Quaternion.Euler(new Vector3(0,0,rz));
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter2D (Collider2D col)
    {
        if (col.tag == "drop")
        {
            col.GetComponent<Rigidbody2D>().velocity = new Vector2(col.GetComponent<Rigidbody2D>().velocity.x,col.GetComponent<Rigidbody2D>().velocity.y * underwaterSlowdown);
            col.GetComponent<Rigidbody2D>().drag = underwaterDrag;
        }
    }
}
