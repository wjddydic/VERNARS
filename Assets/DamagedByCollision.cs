using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamagedByCollision : MonoBehaviour {

    public int health = 1;

    float invulntimer = 0;
    int correctLayer;
    void Start ()
    {
        correctLayer = gameObject.layer;
    }
    void OnTriggerEnter2D()
    {
        Debug.Log("Trigger!");

       
            health--;
            invulntimer = 1f;
            gameObject.layer = 10;
    }

    void Update ()
    {

        invulntimer -= Time.deltaTime;
        if(invulntimer <= 0)
        {
            gameObject.layer = correctLayer;
        }

        if(health <= 0)
        {
            Die();
        }
    }

    void Die ()
    {
        Destroy(gameObject);
    }

}
