using System;
using UnityEngine;

public interface IDammage
{
    // Vars
    public float CurrentHealth { get;}
    public float MaxHealth { get; }
    public bool IsDead { get; } 

    // Methods
    public void TakeDamage(float damage);
    public void Heal(float amount);
    public float GetCurrentHealth();
    public float GetMaxHealth();

    // Events
    public event Action<float> OnTakeDamage;

    public event Action<float> OnHeal;

    public event Action OnDeath;

    public event Action OnRevive;

    public event Action OnHealthUpdate;


}

