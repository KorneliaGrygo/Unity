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
    void OnTriggerEnter2D(Collision2D collision)
    {
        collision.collider.enabled = false;
        if(collision.gameObject.layer == (int)Layers.Player)
        {
            FindObjectOfType<AudioManager>().Stop();
            //FindObjectOfType<AudioManager>().Play("coś");
            animator.SetBool("Happy",true);
        }
    }
}
