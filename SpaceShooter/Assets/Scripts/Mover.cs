using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour {

    Rigidbody rb;
    public float speed;

    private void Start() {
        rb = GetComponent<Rigidbody>();
        rb.velocity = transform.forward * speed;
        
    }

    private void Update()
    {
        /*if (rb.transform.position.z > 18){
            Destroy(gameObject);
        }*/
    }

}
