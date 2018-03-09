using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(Rigidbody))]
public class PlayerController : MonoBehaviour {

    Rigidbody rb;

    [Header("Movement")]
    [SerializeField] float movementSpeed;
    [SerializeField] float jumpingForce;

	
	void Start () {
        rb = GetComponent<Rigidbody>();

	}

    void FixedUpdate()
    {
        Move();
        Jump();
    }

    private void Move()
    {
        Vector3 input = new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical"));
        Vector3 direction = input.normalized;
        Vector3 velocity = direction * movementSpeed;

        //velocity.y = rb.velocity.y;

        rb.MovePosition(rb.position + velocity * Time.deltaTime);
    }

    private void Jump()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Vector3.up * jumpingForce * Time.deltaTime, ForceMode.Impulse);
        }
    }

}
