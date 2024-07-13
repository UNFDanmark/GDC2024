using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class BulletScript : MonoBehaviour
{
    [FormerlySerializedAs("someCooldown")]
    public float lifetime = 10f;
    float someCooldownLeft;

    void Start()
    {
        someCooldownLeft = lifetime;
    }

    public void Update()
    {
        // Tæl tiden ned
        someCooldownLeft = someCooldownLeft - Time.deltaTime;
        if (someCooldownLeft <= 0) 
        {
            // Gør noget her 
            GameObject.Destroy(gameObject);
        
            // Reset hvor meget tid er tilbage
            someCooldownLeft = lifetime;
        }
    }
}
