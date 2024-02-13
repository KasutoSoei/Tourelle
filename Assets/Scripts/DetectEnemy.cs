using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectEnemy : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        // if the colliding object is an enemy
        if (collision.gameObject.CompareTag("Enemy"))
        {
            //destroy the bullet and deal damages to the enemy
            Destroy(gameObject);
            collision.GetComponent<EnemyLife>().DealDamages();
        }
    }
}
