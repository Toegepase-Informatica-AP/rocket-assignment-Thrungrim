using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocketMove : MonoBehaviour
{
    private Rigidbody rb;
    public float speed;
    private float dirZ;
    private float dirY;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        dirZ = Input.GetAxis("Horizontal") * speed;
        dirY = Input.GetAxis("Vertical") * speed;
    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector3(rb.velocity.x, dirY, dirZ);
    }
}
