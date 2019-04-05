﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileShooter : MonoBehaviour {

    // Use this for initialization
    public GameObject prefab;
	void Start () {
        prefab = Resources.Load("projectile") as GameObject;
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetMouseButtonDown(1))
        {
            GameObject projectile = Instantiate(prefab) as GameObject;

            projectile.transform.position = transform.position + Camera.main.transform.forward * 2;

            Rigidbody rb = projectile.GetComponent<Rigidbody>();

            rb.velocity = Camera.main.transform.forward * 40;

            Destroy(projectile, 10.0f);

        }
	}
}
