using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class EnemyMovement : MonoBehaviour
{
    public Transform player;
    public Transform targetObject;
    public Transform newTarget;

    public float speed;
    public float attkdmg;
    void Start()
    {
        newTarget = targetObject;
    }

    void Update()
    {
        var step = speed * Time.deltaTime;
        Vector3 targetPosition = new Vector3(newTarget.position.x, transform.position.y, newTarget.position.z);
        transform.position = Vector3.MoveTowards(transform.position, targetPosition, step);

        Vector3 targetDirection = new Vector3(newTarget.position.x, transform.position.y, newTarget.position.z) - transform.position;
        Vector3 newDirection = Vector3.RotateTowards(transform.forward, targetDirection, step, 0.0f);
        transform.rotation = Quaternion.LookRotation(newDirection);

        float distance = Vector3.Distance(player.position, transform.position);
        if (distance < 0.5f)
        {
            Destroy(gameObject);
        }
    }
}
