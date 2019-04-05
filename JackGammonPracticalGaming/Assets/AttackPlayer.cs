using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackPlayer : MonoBehaviour
{

    public float attackDamage = 35f;
    public float attackDistance = 1.5f;
    private Transform player;

    private void Start()
    {
        player = GameObject.Find("Player").GetComponent<Transform>();
    }

    void Update()
    {
      if(Vector3.Distance(transform.position, player.position) < attackDistance)
        {
            transform.LookAt(player);
            transform.position = Vector3.MoveTowards(transform.position, player.position, 2 * Time.deltaTime);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(GetComponent<Collider>())
        {
            other.transform.GetComponent<HealthScript>().RemoveHealth(attackDamage);
        }
    }

}
