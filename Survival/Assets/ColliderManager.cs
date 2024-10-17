using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderManager : MonoBehaviour
{
    public Transform player;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision != null)
        {
            if (collision.gameObject.CompareTag("Enemy"))
            {
                EnemyMovement enemy = collision.gameObject.GetComponent<EnemyMovement>();
                enemy.newTarget = player.transform;
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other != null)
        {
            if (other.gameObject.CompareTag("Enemy"))
            {
                EnemyMovement enemy = other.gameObject.GetComponent<EnemyMovement>();
                enemy.newTarget = player.transform;
            }
        }
    }
}
