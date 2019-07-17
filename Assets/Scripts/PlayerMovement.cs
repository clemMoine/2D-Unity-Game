using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {
   public Animator animator;

   public CharacterController2D controller;

   public float runSpeed = 40f;

   float horizontalMove = 0f;
   bool jump = false;
   bool crouch = false;

   // Update is called once per frame
   void Update() {
      // Horizontal movement (D/Right = 1 A/Left = -1)
      horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;

      // Always positive speed movement
      animator.SetFloat("Speed", Mathf.Abs(horizontalMove));

      // Press the jump button
      if (Input.GetButtonDown("Jump")) {
         jump = true;
      }

      // Press the crouch button
      if (Input.GetButtonDown("Crouch")) {
         crouch = true;
      } else if (Input.GetButtonUp("Crouch")) {
         crouch = false;
      }
   }

   /// This function is called every fixed framerate frame, if the MonoBehaviour is enabled.
   void FixedUpdate() {
      // Move our character
      controller.Move(horizontalMove * Time.fixedDeltaTime, crouch, jump);
      jump = false;
   }
}