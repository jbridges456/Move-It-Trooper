using UnityEngine;

public class Health : MonoBehaviour

{
    public float MaxHealth = 100;
    private float CurrentHealth;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        CurrentHealth = MaxHealth;

    }

    public void  Damage(float damage)
     
    {
        CurrentHealth = CurrentHealth - damage;
        if (CurrentHealth <= 0&& TryGetComponent<AbstractDeath>(out AbstractDeath DeathCommponent))
        {
            DeathCommponent.Die();
        }
       
    }
    public void Healing(float healing) 
    {
        CurrentHealth = CurrentHealth + healing;
        CurrentHealth = Mathf.Min(CurrentHealth, MaxHealth);
    }
   
}
