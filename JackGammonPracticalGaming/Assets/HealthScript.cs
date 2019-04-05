using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthScript : MonoBehaviour {

    public float health = 100f;
    public bool isPlayer = false;

    public void RemoveHealth(float amount)

    {
        health -= amount;
        if(health <= 0)
        {
            //Application.LoadLevel(0);
        }

        else
        {
            Destroy(gameObject);
        }
    }


}
