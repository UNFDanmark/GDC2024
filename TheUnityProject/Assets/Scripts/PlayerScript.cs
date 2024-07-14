using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public float speed = 10; // Speed of the player

    Rigidbody m_RigidBody;
    public Animator animator;
    
    public int health = 3;
    
    int currentHealth;
    public TMPro.TMP_Text healthText;
    
    void Start()
    {
        m_RigidBody = GetComponent<Rigidbody>();
        currentHealth = health;
    }
    
    void Update()
    {
        Vector3 velocity = m_RigidBody.velocity;
        velocity.x = Input.GetAxisRaw("Horizontal") * speed;
        velocity.z = Input.GetAxisRaw("Vertical") * speed;
        m_RigidBody.velocity = velocity;
        
        animator.SetFloat("Speed", velocity.magnitude);
    }
    
    public GameObject gameOverScreen;

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            currentHealth = currentHealth - 1;
            if (currentHealth <= 0)
            {
                healthText.text = "";
                gameOverScreen.SetActive(true);
            }
            else
            {
                healthText.text = "Health: " + currentHealth + "/" + health;
            }
        }
    }
}
