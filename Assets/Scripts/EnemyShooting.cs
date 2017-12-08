using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShooting : MonoBehaviour {
   
    //PlayerShooting과 동일
    public Vector3 bulletOffset = new Vector3(0, 0.5f, 0);

    //총알 생성
    public GameObject bulletPrefab;
    int bulletLayer;

    //발사 딜레이
    public float fireDelay = 0.5f;
    float cooldownTimer = 0;

    Transform player;

    void Start()
    {

        bulletLayer = gameObject.layer;
    }

    void Update()
    {

        if (player == null)
        {
            //enemy가 player 찾기
            GameObject go = GameObject.FindWithTag("Player");

            if (go != null)
            {
                player = go.transform;
            }
        }

        cooldownTimer -= Time.deltaTime;
        
        //적이 스폰되고 바로 총 발사하지 못하게 함
        if  (cooldownTimer <= 0 && player != null && Vector3.Distance(transform.position, player.position) < 4)
        {
           // Debug.Log("Enemy Shoot");
            cooldownTimer = fireDelay;

            Vector3 offset = transform.rotation * bulletOffset;

            GameObject bulletGO = (GameObject)Instantiate(bulletPrefab, transform.position, transform.rotation);
            bulletGO.layer = bulletLayer;
        }
    }
}
