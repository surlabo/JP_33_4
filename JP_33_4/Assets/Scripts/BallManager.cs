using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallManager : MonoBehaviour
{
    public float speed;
    public float sprintSpeed;
    public float rotateSpeed;
    public float jumpForce;
    public Color defaultColor;
    public Color newColor;
    public static Color randomColor;


    Rigidbody rb;
    bool isGrounded;


    private void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
       // StartCoroutine(Logger());
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.LeftShift))
        {
            PlayerMovement(sprintSpeed);
        }
        else
        {
            PlayerMovement(speed);
        }


        PlayerRotation();

        Jump();
    }

    void PlayerMovement(float newSpeed)
    {
        transform.Translate(0, 0, Input.GetAxis("Vertical") * newSpeed * Time.deltaTime);
    }

    void PlayerRotation()
    {
        transform.Rotate(0, Input.GetAxis("Horizontal") * rotateSpeed * Time.deltaTime, 0);
    }

    void Jump()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(0, jumpForce, 0);
        }
    }

    IEnumerator Logger()
    {
        int x = 0;
        while(true)
        {
            yield return null;
            Debug.Log(x++);
        }
    }

  
    private void OnCollisionEnter(Collision collision)
    {
        isGrounded = true;

        if (collision.gameObject.tag == "Floor")
        {
            collision.gameObject.GetComponent<MeshRenderer>().material.color = newColor;
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        collision.gameObject.GetComponent<MeshRenderer>().material.color = defaultColor;
        isGrounded = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Spawn")
        {
            var level = other.gameObject.GetComponent<SpawnPointA>().level;
            PlayerPrefs.SetInt("Level", level);
        }
    }
}



