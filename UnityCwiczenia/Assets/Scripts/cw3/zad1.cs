using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zad1 : MonoBehaviour
{
    public float speed = 2.0f;
    Rigidbody rigi;
    Vector3 pA = new Vector3(0,0,0);
    Vector3 pB = new Vector3(10,0,0);

    // Start is called before the first frame update
    void Start()
    {
        rigi = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.Lerp(pA, pB, Mathf.PingPong(Time.time, speed));
    }
}
