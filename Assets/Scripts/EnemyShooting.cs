using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShooting : MonoBehaviour {
    
    //PlayerShooting과 동일

    //총알 생성
    public GameObject bulletPrefab;

    //발사 딜레이
    public float fireDelay = 0.5f;
    float cooldownTimer = 0;

    void Update()
    {

        cooldownTimer -= Time.deltaTime;

        if  (cooldownTimer <= 0)
        {
            Debug.Log("Enemy Shoot");
            cooldownTimer = fireDelay;

            GameObject bulletGO = (GameObject)Instantiate(bulletPrefab, transform.position, transform.rotation);
            bulletGO.layer = gameObject.layer;
        }
    }
}
