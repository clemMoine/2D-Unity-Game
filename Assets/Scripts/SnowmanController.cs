using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnowmanController : MonoBehaviour
{
    public Animator animator;

    public float runSpeed = 40f;

    float horizontalMove = 0f;
    bool jump = false;
    bool crouch = false;

    // Update is called once per frame
    void Update()
    {
        horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;

        // Always positive speed movement
        animator.SetFloat("Speed", Mathf.Abs(horizontalMove));

        //if (Input.GetButtonDown("Jump"))
        //{
        //    jump = true;
        //}

        //if (Input.GetButtonDown("Crouch"))
        //{
        //    crouch = true;
        //} else if (Input.GetButtonUp("Crouch"))
        //{
        //    crouch = false;
        //}

        //Vector3 horizontal = new Vector3(Input.GetAxis("Horizontal"), 0.0f, 0.0f);
        //transform.position = transform.position + horizontal * Time.deltaTime;
    }
}
