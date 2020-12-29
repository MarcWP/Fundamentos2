using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthManager : MonoBehaviour
{
    public int TotalHealth = 100;
    public int updatedHealth;
    public HealthBar healthbar;
    // Start is called before the first frame update
    void Start()
    {
        updatedHealth = TotalHealth;
        GameEvent.current.onTakeHit += substractHealth;
    }

    private void substractHealth()
    {
        updatedHealth -= 20;
        healthbar.setHealth(updatedHealth);
        if (updatedHealth <= 0)
        {

            GameEvent.current.death();
        }
    }
    
}
