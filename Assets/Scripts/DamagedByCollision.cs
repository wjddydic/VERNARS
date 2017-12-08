﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamagedByCollision : MonoBehaviour {


    public int health = 1;
    public float invulnPeriod = 0;
    float invulnTimer = 0;
    int correctLayer;

    SpriteRenderer spriteRend;

    void Start ()
    {
        correctLayer = gameObject.layer;

        spriteRend = GetComponent<SpriteRenderer>();

        if(spriteRend == null)
        {
            spriteRend = transform.GetComponentInChildren<SpriteRenderer>();

            if (spriteRend == null)
            {
                Debug.LogError("object '" + gameObject.name + "' has no sprite rendered.");
            }
        }

    }

    void OnTriggerEnter2D()
    {
        health--;

        if (invulnPeriod > 0) { 
             //맞고나서 딜레이
             invulnTimer = invulnPeriod;
             gameObject.layer = 10;
        }
    }

    void Update ()
    {
        if(invulnTimer > 0)
        {
            invulnTimer -= Time.deltaTime;

            if(invulnTimer <= 0)
            {
                gameObject.layer = correctLayer;
                if(spriteRend != null)
                {
                    spriteRend.enabled = true;
                }
            }
            else
            {
                if (spriteRend != null)
                {
                    spriteRend.enabled = !spriteRend.enabled;
                }
            }
        }

        if(health <= 0)
        {
            Die();
        }
     }
    void Die()
    {
        Destroy(gameObject);
    }
}
