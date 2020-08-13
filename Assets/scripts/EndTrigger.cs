using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndTrigger : MonoBehaviour
{

    // Start is called before the first frame update

    void OnTriggerEnter(Collider c) 
    {
        //GetComponent<PlayerMovement>().enabled = false;
        FindObjectOfType<GameManager>().CompleteLevel();
    }
}
