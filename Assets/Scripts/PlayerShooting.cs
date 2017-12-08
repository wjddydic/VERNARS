using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShooting : MonoBehaviour {
   
    //발사 위치 조정
    public Vector3 bulletOffset = new Vector3(0, 0.5f, 0);

    //총알 생성
    public GameObject bulletPrefab;
    int bulletLayer;
    //발사 딜레이
    public float fireDelay = 0.25f;

    float cooldownTimer = 0;

    void Start () {

        bulletLayer = gameObject.layer;
    }

	void Update () {

        cooldownTimer -= Time.deltaTime;

        if (Input.GetButton("Fire1") && cooldownTimer <= 0)
        {
            cooldownTimer = fireDelay;

            Vector3 offset = transform.rotation * bulletOffset;
            
            GameObject bulletGo = (GameObject)Instantiate(bulletPrefab, transform.position + offset, transform.rotation);
            bulletGo.layer = bulletLayer;
        }
	}
}
