using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5f;
    private Rigidbody rb;
    public float mouseSensitivity = 100f;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;

        transform.Rotate(Vector3.up * mouseX);
    }
    void FixedUpdate()
    {
        float moveX = Input.GetAxis("Horizontal");
        float moveZ = Input.GetAxis("Vertical");
        Vector3 move = new Vector3(moveX, 0, moveZ);
        rb.MovePosition(rb.position + move * moveSpeed * Time.fixedDeltaTime);
    }




}
