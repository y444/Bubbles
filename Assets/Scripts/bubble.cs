﻿using UnityEngine;
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
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        speed = minSpeed + ((maxSpeed - minSpeed) * (lifetime / maxLifetime));
        amplitude = minAmplitude + ((maxAmplitude - minAmplitude) * (lifetime / maxLifetime));

        float newScale = minScale + ((maxScale - minScale) * (lifetime / maxLifetime));
        transform.localScale = new Vector3(newScale, newScale, transform.localScale.z);

        lifetime += Time.deltaTime;
        if (lifetime < maxLifetime)
        {
            transform.position = new Vector3(transform.position.x   + ((float)Math.Sin(Time.time + randomIndex) * amplitude), transform.position.y + speed, transform.position.z);
        }
        else
        {
            Destroy(this.gameObject);
        }
    }
}
