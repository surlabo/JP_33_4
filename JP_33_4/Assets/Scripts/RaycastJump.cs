using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaycastJump : MonoBehaviour
{
    public float detectDistance = 2;
    public float jumpForce = 500;

    private Rigidbody rb;


    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        Debug.DrawRay(transform.position, Vector3.down * detectDistance, Color.red);
        if (Physics.Raycast(transform.position, Vector3.down, out RaycastHit hit, detectDistance))
        {
            if (hit.transform.CompareTag("Floor") && Input.GetKeyDown(KeyCode.Space))
            {
                rb.AddForce(Vector3.up * jumpForce);
            }
        }
    }
}
