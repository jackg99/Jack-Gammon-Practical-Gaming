using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour {

    public GameObject bullet;
    public float delayTime = 0.5f;
    public float enemyDamage = 25f;

    private float counter = 0;

    private void FixedUpdate()
    {
        if(Input.GetKey(KeyCode.Mouse0) && counter > delayTime)
        {
            Instantiate(bullet, transform.position, transform.rotation);
            counter = 0;

            RaycastHit hit;
            Ray ray = new Ray(transform.position, transform.forward);
            if(Physics.Raycast(ray, out hit, 300f))
            {
                if(hit.transform.tag == "Enemy")
                {
                    hit.transform.GetComponent<HealthScript>().RemoveHealth(enemyDamage);
                }
            }
        }
        counter += Time.deltaTime;
    }

}
