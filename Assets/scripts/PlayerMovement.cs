using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody rigidbody;
    public Transform tf;
    public PlayerCollision pc;

    public float forwardforce = 2000f;
    public float sideforce = 500f;
    // void Start()
    // {
    //     rigidbody.AddForce(0, 200, 500);
    // }

    // Update is called once per frame
    void FixedUpdate()
    {
        rigidbody.AddForce(0,0, forwardforce * Time.deltaTime);
        if (Input.GetKey("d")){
            rigidbody.AddForce(sideforce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey("a")){
            rigidbody.AddForce(-sideforce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        // if (Input.GetKey("w")){
        //     rigidbody.AddForce(0,0, forwardforce * Time.deltaTime, ForceMode.VelocityChange);
        // }
        // if (Input.GetKey("s")){
        //     rigidbody.AddForce(0,0,-forwardforce * Time.deltaTime, ForceMode.VelocityChange);
        // }
        if(tf.position.y < -2f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
