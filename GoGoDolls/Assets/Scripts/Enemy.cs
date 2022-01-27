using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public CharacterController2D characterController;
    public float enemySpeed = 100f;
    public int direction = 1;
    public int faceSide = 1;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.layer == (int)Layers.Przeszkoda && collision.gameObject.layer != (int)Layers.Ground)
        {
            Vector3 theScale = transform.localScale;
            faceSide *= -1;
            theScale.x *= faceSide;
            transform.localScale = theScale;
            direction *= -1;

        }
        if (collision.gameObject.layer == (int)Layers.Player )
        {
            FindObjectOfType<AudioManager>().Play("Opos");
            if (PointsCounter.coins >= 0)
                PointsCounter.coins--;
            if (PointsCounter.coins < 0)
                PointsCounter.coins = 0;
        }
    }
    private void FixedUpdate()
    {
        characterController.Move(direction * enemySpeed * Time.fixedDeltaTime, false, false);
    }
}
public enum Layers
{
    Ground = 8,
    Przeszkoda = 11,
    Player = 10,
}
