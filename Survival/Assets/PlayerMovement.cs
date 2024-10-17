using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed;
    Rigidbody rb;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        float hInput = Input.GetAxis("Horizontal");
        Vector3 move = new Vector3(hInput, 0 , 0);
        move.Normalize();

        transform.Translate(speed * Time.deltaTime * move, Space.World);
    }
}
