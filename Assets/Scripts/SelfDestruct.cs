using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelfDestruct : MonoBehaviour {

    //총알 자동 제거
    public float timer = 5f;

	void Update () {
        timer -= Time.deltaTime;

            if(timer <= 0)
            {
            Destroy(gameObject);
            }
		
	}
}
