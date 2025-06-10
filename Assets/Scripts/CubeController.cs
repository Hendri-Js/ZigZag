using System;
using UnityEngine;

public class CubeController : MonoBehaviour
{
    [SerializeField] private float moveSpeed;
    private bool moveDirectionTrigger;
    private bool started;
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

        if (!started)
        {
            if (Input.GetMouseButtonDown(0))
            {
                started = true;
                rb.linearVelocity = new Vector3(moveSpeed, 0, 0);
            }
        }

        if (Input.GetMouseButtonDown(0))
        {
            moveDirectionTrigger = true;
        }
    }

    void FixedUpdate()
    {
        if (moveDirectionTrigger)
        {
            SwitchDirection();
            moveDirectionTrigger = false;
        }
    }

    void SwitchDirection()
    {
        if (rb.linearVelocity.z > 0)
        {
            rb.linearVelocity = new Vector3(moveSpeed, 0, 0);
        } 
        else if (rb.linearVelocity.x > 0)
        {
            rb.linearVelocity = new Vector3(0, 0, moveSpeed);
        }
    }

}
