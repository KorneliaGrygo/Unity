using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HearthCollision : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        FindObjectOfType<AudioManager>().Play("Serduszko");
        PointsCounter.coins++;
        Destroy(gameObject, 0.01f);
    }

}
