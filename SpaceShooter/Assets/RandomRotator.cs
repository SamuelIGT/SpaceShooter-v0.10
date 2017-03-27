using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomRotator : MonoBehaviour {

    public float tumble;
    Rigidbody rb;

    private void Start(){
        rb = GetComponent<Rigidbody>();

        rb.angularVelocity = Random.insideUnitSphere * tumble;
    }

}
