using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public float speed = 10; // Speed of the player

    Rigidbody m_RigidBody;
    public Animator animator;
    
    void Start()
    {
        m_RigidBody = GetComponent<Rigidbody>();
    }
    
    void Update()
    {
        Vector3 velocity = m_RigidBody.velocity;
        velocity.x = Input.GetAxisRaw("Horizontal") * speed;
        velocity.z = Input.GetAxisRaw("Vertical") * speed;
        m_RigidBody.velocity = velocity;
        
        animator.SetFloat("Speed", velocity.magnitude);
    }
}
