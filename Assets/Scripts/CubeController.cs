using System;
using UnityEngine;

public class CubeController : MonoBehaviour
{
    [SerializeField] private float moveSpeed;

    private bool moveX;
    private bool triggerX = true;
    private Rigidbody rb;


    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //rb.linearVelocity = new Vector3(moveSpeed, 0, 0);

        if (Input.GetMouseButtonDown(0))
        {
            if (triggerX)
            {
                moveX = true;
                triggerX = false;
            }
            else
            {
                moveX = false;
                triggerX = true;
            }
        }
    }


    void FixedUpdate()
    {
        if (moveX)
        {
            MoveXDirection();
        }
        else
        {
            MoveZDirection();
        }
    }

    void MoveXDirection()
    {
        rb.linearVelocity = new Vector3(moveSpeed, 0f, 0f);
    }

    void MoveZDirection()
    {
        rb.linearVelocity = new Vector3(0f, 0f, moveSpeed);
    }
}
