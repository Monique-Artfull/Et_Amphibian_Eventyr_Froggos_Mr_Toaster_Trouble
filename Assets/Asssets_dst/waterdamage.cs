using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class waterdamage : MonoBehaviour


{
    public int damageAmount = 10; // The amount of damage the mesh will give
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void GiveDamage(Collider other)
{
    // Apply damage to the collider's attached GameObject
    other.gameObject.SendMessage("ApplyDamage", damageAmount);
}
}

