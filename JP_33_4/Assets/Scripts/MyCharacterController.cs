using System.Collections;
using System.Collections.Generic;
using UnityEditor.Animations;
using UnityEngine;

public class MyCharacterController : MonoBehaviour
{
    public Animator controller;

    public float runningSpeed;
   

    void Update()
    {
        //if (Input.GetKeyDown(KeyCode.W))
        //{
        //    controller.SetBool("IsRunning", true);

        //}
        //else if (Input.GetKeyUp(KeyCode.W))
        //{
        //    controller.SetBool("IsRunning", false);
        //}

        PlayerMovement();
        PlayerRotation();
    }

    void PlayerMovement()
    {
        var movementDir = Input.GetAxis("Vertical");
        transform.Translate(0, 0, Input.GetAxis("Vertical") * runningSpeed * Time.deltaTime);
        Debug.Log(movementDir);
        var animSpeed = Mathf.Lerp(controller.GetFloat("Blend"), movementDir, Time.deltaTime * 100);
        controller.SetFloat("Blend", animSpeed);
    }

    void PlayerRotation()
    {
        transform.Rotate(0, Input.GetAxis("Horizontal") * 200 * Time.deltaTime, 0);
    }
}
