using System;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    public float cooldown = 3; // Time in seconds between each attack

    UnityEngine.AI.NavMeshAgent agent;
    private GameObject player;
    public Animator animator;

    void Start()
    {
        player = GameObject.FindWithTag("Player");
        agent = GetComponent<UnityEngine.AI.NavMeshAgent>();
    }

    void Update()
    {
        agent.SetDestination(player.transform.position);
        animator.SetFloat("Speed", agent.velocity.magnitude);
    }

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Bullet"))
        {
            // Attack the player
            Destroy(gameObject);
            Destroy(other.gameObject);
        }
    }
}
