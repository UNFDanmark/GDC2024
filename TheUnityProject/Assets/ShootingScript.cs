using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ShootingScript : MonoBehaviour
{
    public float rotationSpeed = 90;
    
    // Update is called once per frame
    void Update()
    {
        float rotateAroundY = Input.GetAxisRaw("TurnAround");
        transform.Rotate(0, rotateAroundY*rotationSpeed*Time.deltaTime, 0);
    }
}
