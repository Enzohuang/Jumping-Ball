using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Transform tf;
    public Text stext;

    private float originalZ;

    void Start()
    {
        originalZ = tf.position.z;
    }
    // Update is called once per frame
    void Update()
    {
        stext.text = (tf.position.z - originalZ).ToString("0");
    }
}
