using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    Rigidbody rb;

    void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    Vector3 mov = Vector3.zero;

    [SerializeField] ForceMode fm;

    [SerializeField] float runSpeed = 3;
    [SerializeField] float currentSpeed = 3;

    float jumpPower = 300;

    [SerializeField] int jumpMaxCount = 2;
    int remainJumpCount = 2;

    void Jump()
    {
        if (remainJumpCount == 0)
        {
            return;
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            remainJumpCount--;

            rb.velocity = Vector3.zero;
            rb.AddForce(Vector3.up * jumpPower);
        }
    }

    void Move()
    {
        mov.x = Input.GetAxis("Horizontal");
        mov.z = Input.GetAxis("Vertical");


        if (Input.GetKey(KeyCode.LeftShift))
        {
            currentSpeed = runSpeed;
        }
        else
        {
            currentSpeed = 1;
        }

        rb.position += mov * Time.deltaTime * currentSpeed;
    }

    void Update()
    {
        Move();

        Jump();
    }

    private void OnCollisionEnter(Collision collision)
    {
        remainJumpCount = jumpMaxCount;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("One"))
        {
            remainJumpCount++;
            other.gameObject.SetActive(false);
        }
        else if (other.CompareTag("JumpUp"))
        {
            jumpMaxCount++;
            other.gameObject.SetActive(false);
        }
        else if (other.CompareTag("JumpFloor"))
        {
            rb.velocity = Vector3.zero;
            rb.AddForce(Vector3.up * jumpPower * 2);
        }
    }
}
