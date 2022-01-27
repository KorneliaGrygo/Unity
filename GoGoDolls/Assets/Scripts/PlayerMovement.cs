using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController2D controller2D;
    float horizontalMove = 0f;
    public float runSpeed = 20f;
    bool jump = false;
    bool crouch = false;
    public Animator animator;
    private void Awake()
    {
        FindObjectOfType<AudioManager>().Play("Las");
    }
    // Update is called once per frame
    void Update()
    {
        horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;
        animator.SetFloat("Speed", Mathf.Abs(horizontalMove));
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.UpArrow))
        {
            animator.SetBool("isJump", true);
            jump = true;
        }
        if (Input.GetKeyDown(KeyCode.DownArrow) || Input.GetKeyDown(KeyCode.LeftControl))
        {
            crouch = true;
        }
        else if (Input.GetKeyUp(KeyCode.DownArrow) || Input.GetKeyUp(KeyCode.LeftControl))
        {
            animator.SetBool("IsCrouch", true);
            crouch = false;
        }
    }

    private void FixedUpdate()
    {
        controller2D.Move(horizontalMove * Time.fixedDeltaTime, crouch, jump);
        jump = false;
        
    }
    public void OnLand()
    {
        if(jump == false)
            animator.SetBool("isJump", false);
    }
    public void OnCrouch(bool isCrouching)
    {
         animator.SetBool("IsCrouch", isCrouching);
    }
}
