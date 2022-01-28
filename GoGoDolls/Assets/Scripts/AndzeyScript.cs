using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AndzeyScript : MonoBehaviour
{
    public Animator animator;
    public void Awake()
    {
        animator = GetComponent<Animator>();
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.layer == (int)Layers.Player)
        {
            FindObjectOfType<AudioManager>().Stop();
            FindObjectOfType<AudioManager>().Play("Krzysio");
            animator.SetBool("Happy",true);
        }
    }
}
