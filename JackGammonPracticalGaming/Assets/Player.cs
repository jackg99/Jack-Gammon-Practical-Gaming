using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour {

    public int maxHealth;
    public Text currentHealthLabel;
    private int currentHealth;

	// Use this for initialization
	void Start () {

        currentHealth = maxHealth;
        UpdateGUI();
	}
	
	// Update is called once per frame
	void UpdateGUI()
    {
        currentHealthLabel.text = currentHealth.ToString();
		
	}

    public void AlterHealth(int amount)
    {
        currentHealth += amount;
        currentHealth = Mathf.Clamp(currentHealth, 0, maxHealth);
        UpdateGUI();
    }
}
