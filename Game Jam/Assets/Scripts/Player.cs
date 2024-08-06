using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private string inputNameHorizontal;
    [SerializeField] private string inputNameVertical;
    Vector3 moveDir;

    [SerializeField] private Color color;

    private Rigidbody rb;
    private Renderer renderer;

    private float inputHorizontal;
    private float inputVertical;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        renderer = GetComponentInChildren<Renderer>();
        renderer.material.color = color;
    }

    private void Update()
    {
        inputHorizontal = Input.GetAxisRaw(inputNameHorizontal);
        inputVertical = Input.GetAxisRaw(inputNameVertical);
        Move();
    }

    private void Move()
    {
        moveDir = new Vector3(inputHorizontal, rb.velocity.y, inputVertical).normalized;

        rb.MovePosition(transform.position + moveDir * speed * Time.fixedDeltaTime);
        if (moveDir != Vector3.zero)
        {
            Quaternion toRotation = Quaternion.LookRotation(moveDir, Vector3.up);
            rb.rotation = Quaternion.RotateTowards(rb.rotation, toRotation, 360 * Time.fixedDeltaTime);
        }
    }
}
