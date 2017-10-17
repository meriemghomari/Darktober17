using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFollower : EnemyBehaviour {

    GameObject player;
    void Start() {
       
    }

    void OnTriggerEnter2D(Collider2D Other) {
        if (Other.gameObject.tag == "Player") {
            Debug.Log("caca");
        }
    }
}
