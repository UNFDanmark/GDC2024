using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ShootingScript : MonoBehaviour
{
    public float rotationSpeed = 90;
    public GameObject bulletPrefab;
    public Animator animator;
    
    public float cooldown;
    float cooldownLeft;
    
    // Update is called once per frame
    void Update()
    {
        float rotateAroundY = Input.GetAxisRaw("TurnAround");
        transform.Rotate(0, rotateAroundY*rotationSpeed*Time.deltaTime, 0);

        if (Input.GetKeyDown(KeyCode.Space) && cooldownLeft <= 0) 
        {
            var go = Instantiate(bulletPrefab ,transform.position,Quaternion.identity);
            go.GetComponent<Rigidbody>().velocity = transform.forward * 10;
            
            animator.SetTrigger("Shoot");
            cooldownLeft = cooldown;
        }
        cooldownLeft -= Time.deltaTime;
    }
}
