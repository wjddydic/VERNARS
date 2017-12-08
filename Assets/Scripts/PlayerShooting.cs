using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShooting : MonoBehaviour {

    //총알 생성
    public GameObject bulletPrefab;
 
    //발사 딜레이
    public float fireDelay = 0.25f;
    float cooldownTimer = 0;

	void Update () {

        cooldownTimer -= Time.deltaTime;

        if (Input.GetButton("Fire1") && cooldownTimer <= 0)
        {
            Debug.Log("Shoot");
            cooldownTimer = fireDelay;
            Instantiate(bulletPrefab, transform.position, transform.rotation);
        }
	}
}
