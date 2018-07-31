using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Include Artificial Intelligence part of API
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{
    private int health = 100;

    public int Health
    {
        get
        {
            return health;
        }
    }

    public NavMeshAgent agent;
    public Transform target;

    // Update is called once per frame
    void Update()
    {
        // Update the AI's target position
        agent.SetDestination(target.position);
    }

    public void DealDamage(int damageDealt)
    {
        health -= damageDealt;
        if (health <= 0)
        {
            Destroy(gameObject);
        }
    }
}