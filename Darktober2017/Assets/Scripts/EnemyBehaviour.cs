using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehaviour : MonoBehaviour {

    Vector2 startPosition;
    Vector2 currentPosition;
    Vector2 target;
    [SerializeField]
    float speed;
    [SerializeField]
    GameObject targetObject;
    GameObject player;
    [SerializeField]
    Transform view;
    SpriteRenderer SR;
    [SerializeField]
    SpriteRenderer viewSR;
    bool followPlayer;

    // Use this for initialization
    void Start () {
        startPosition = transform.position;
        target = targetObject.transform.position;
        player = GameObject.FindGameObjectWithTag("Player");

        SR = GetComponent<SpriteRenderer>();
    }
	
	// Update is called once per frame
	void Update () {
        currentPosition = transform.position;

        if (followPlayer) {
            speed = 1.0f;
            Vector2 targetPlayer = new Vector2(player.transform.position.x, transform.position.y);
            transform.position = Vector2.MoveTowards(transform.position, targetPlayer, 3 * Time.deltaTime);

        }
        else {

            if (currentPosition != target) {
                transform.position = Vector2.MoveTowards(currentPosition, target, speed * Time.deltaTime);

            }
            if (currentPosition == target) {
                target = startPosition;
                SR.flipX = false;
                viewSR.flipX = true;
            }
            if (currentPosition == startPosition) {
                target = targetObject.transform.position;

                SR.flipX = true;
                viewSR.flipX = false;
            }

        }
    }

    void OnTriggerEnter2D(Collider2D Other ) {
       
        if (Other.gameObject.tag == "Player") {
            Debug.Log("player is dead");
            followPlayer = true;

        }
    }


}
