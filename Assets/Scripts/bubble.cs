using UnityEngine;
using System;

public class bubble : MonoBehaviour
{
    public float lifetime;
    public float maxLifetime;
    public float speed;
    public float minSpeed;
    public float maxSpeed;
    public float amplitude;
    public float minAmplitude;
    public float maxAmplitude;
    public float minScale;
    public float maxScale;
    public float randomIndex;
    public GameObject popPrefab;

    void Update()
    {
        
        speed = minSpeed + ((maxSpeed - minSpeed) * (lifetime / maxLifetime));
        amplitude = minAmplitude + ((maxAmplitude - minAmplitude) * (lifetime / maxLifetime));

        float newScale = minScale + ((maxScale - minScale) * (lifetime / maxLifetime));
        transform.localScale = new Vector3(newScale, newScale, transform.localScale.z);

        float newA = 1 - (lifetime / maxLifetime);

        lifetime += Time.deltaTime;
        
        if (lifetime < maxLifetime)
        {
            transform.position = new Vector3(transform.position.x   + ((float)Math.Sin(Time.time + randomIndex) * amplitude), transform.position.y + speed, transform.position.z);
            GetComponent<SpriteRenderer>().color = new Color(GetComponent<SpriteRenderer>().color.r,GetComponent<SpriteRenderer>().color.g,GetComponent<SpriteRenderer>().color.b, newA);
        }
        else
        {
            Destroy(this.gameObject);
        }
    }

    void OnMouseDown()
    {
        Destroy(this.gameObject);
        Instantiate(popPrefab, transform.position, transform.rotation);
    }
}
