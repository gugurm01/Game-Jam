using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    Animator animator;
    [SerializeField] private float speed;
    [SerializeField] private string inputNameHorizontal;
    [SerializeField] private string inputNameVertical;
    Vector3 moveDir;

    public static Player instance;

    [SerializeField] private Color color;

    private Rigidbody rb;
    //private Renderer renderer;

    private float inputHorizontal;
    private float inputVertical;

    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
    }

    private void Start()
    {
        animator = GetComponent<Animator>();
        rb = GetComponent<Rigidbody>();
        //renderer = GetComponentInChildren<Renderer>();
        //GetComponent<Renderer>().material.color = color;
    }

    private void Update()
    {
        inputHorizontal = Input.GetAxisRaw(inputNameHorizontal);
        inputVertical = Input.GetAxisRaw(inputNameVertical);
        if(Input.GetButtonDown("Vertical 1"))
        {
            animator.SetBool("Run", true);
        }
        else if (Input.GetButtonDown("Vertical 2"))
        {
            animator.SetBool("Run", true);
        }
        else if (Input.GetButtonDown("Horizontal 1"))
        {
            animator.SetBool("Run", true);
        }
        else if (Input.GetButtonDown("Horizontal 2"))
        {
            animator.SetBool("Run", true);
        }

        Move();
        
    }

    private void Move()
    {
        moveDir = new Vector3(inputHorizontal, 0, inputVertical).normalized;
        
        rb.velocity = moveDir;
        //rb.MovePosition(transform.position + moveDir * speed * Time.fixedDeltaTime);
        if (moveDir != Vector3.zero)
        {
            Quaternion toRotation = Quaternion.LookRotation(moveDir, Vector3.up);
            rb.rotation = Quaternion.RotateTowards(rb.rotation, toRotation, 360 * 0.1f);
        }
    }
}
