using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FacesPlayer : MonoBehaviour {

    float rotSpeed = 180f;

    Transform player;

	void Update () {
		if(player == null)
        {
            //enemy가 player 찾기
            GameObject go = GameObject.Find("PlayerShip");

            if(go != null)
            {
                player = go.transform;
            }
        }

        if (player == null)
            return;

        Vector3 dir = player.position = transform.position;
        dir.Normalize();

        float zAngle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg- 90;

        Quaternion desiredRot = Quaternion.Euler(0, 0, zAngle);

        transform.rotation = Quaternion.RotateTowards(transform.rotation, desiredRot, rotSpeed * Time.deltaTime);
	}
}
 