using System.Collections;
using System.Collections.Generic;
using UnityEditor.Animations;
using UnityEngine;

public class MyCharacterController : MonoBehaviour
{
    [SerializeField] private Animator controller;
    [SerializeField] private float runningSpeed;
   

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
        Punch();
    }

    void Punch()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {


            controller.SetTrigger("Punch");
        }
    }

    void PlayerMovement()
    {
        var movementDir = Input.GetAxis("Vertical");

        transform.Translate(0, 0, movementDir * runningSpeed * Time.deltaTime);

        var animSpeed = Mathf.Lerp(controller.GetFloat("Blend"), movementDir, Time.deltaTime * 100);

        controller.SetFloat("Blend", animSpeed);
    }

    void PlayerRotation()
    {
        transform.Rotate(0, Input.GetAxis("Horizontal") * 200 * Time.deltaTime, 0);
    }
}
