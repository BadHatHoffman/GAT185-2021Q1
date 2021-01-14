using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 2.0f;

    // Update is called once per frame
    void Update()
    {

        Vector3 velocity = Vector3.zero;

        velocity.x = Input.GetAxis("Horizontal");
        velocity.z = Input.GetAxis("Vertical");

        if (Input.GetButton("Jump")) velocity.y = 10;

        transform.position += velocity * speed * Time.deltaTime;
    }
}