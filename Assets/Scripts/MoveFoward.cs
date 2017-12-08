using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveFoward : MonoBehaviour {

   
    public float maxSpeed = 8f;

	void Update () {
        //플레이어 이동과 동일 (w키 제거)
        Vector3 pos = transform.position;

        Vector3 velocity = new Vector3(0, maxSpeed * Time.deltaTime, 0);

        pos += transform.rotation * velocity;

        transform.position = pos;

    }
}
