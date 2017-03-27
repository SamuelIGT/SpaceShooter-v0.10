using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Boundary{
    public float xMin, xMax, zMin, zMax;
}

public class PlayerController : MonoBehaviour {
    public float speed;
    public float tilt;
    public Boundary boundary;
    private Rigidbody rb;

    public GameObject shot;
    public Transform shot_spawn;

    public float fireRate;
    private float nextFire;

    private void Start() {
        rb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate() {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        rb.velocity = movement * speed;
        rb.position = new Vector3(
            Mathf.Clamp(rb.position.x, boundary.xMin, boundary.xMax),
            0.0f,
            Mathf.Clamp(rb.position.z, boundary.zMin, boundary.zMax)
            );

        rb.rotation = Quaternion.Euler(0.0f, 0.0f, rb.velocity.x * -tilt);
        
    }

    private void Update()
    {
        if(Input.GetButton("Fire1") && Time.time > nextFire){
            nextFire = Time.time + fireRate;
            Instantiate(shot, shot_spawn.position, shot_spawn.rotation);
        }
        

    }
}
