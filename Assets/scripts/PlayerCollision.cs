using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public Transform tf;

    public Vector3 origional;

    public PlayerMovement movement;
        void OnCollisionEnter(Collision info) {
        if(info.collider.tag == "obstacle") {
            GetComponent<PlayerMovement>().enabled = false;
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
