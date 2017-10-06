using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformStay : MonoBehaviour {

    public GameObject player;
    void OnCollisionEnter2D(Collision2D platform)
    {

        if (platform.gameObject.tag == "MovingPlatform")
        {
            player.transform.SetParent(platform.transform);

        }
    }

    void OnCollisionExit2D(Collision2D platform)
    {
        if (platform.gameObject.tag == "MovingPlatform")
        {
            player.transform.SetParent(null);

        }
    }
}
