using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
public class HealthController : MonoBehaviour
{
    [SerializeField] private float currentHealth;
    [SerializeField] private float maximumHealth;

    public float RemainingHealthPercentage
    {
        get
        {
            return currentHealth / maximumHealth;
        }
    }

    public bool IsInvincible { get; set; }

    public UnityEvent OnDied;

    public UnityEvent OnDamaged;

    public void TakeDamage(float damageAmount)
    {
        if (currentHealth == 0)
        {
            return;
        }

        if (IsInvincible)
        {
            return;
        }

        currentHealth -= damageAmount;

        if (currentHealth < 0)
        {
            currentHealth = 0;
        }
        //EnemyWaveSpawner.onEnemyDestroy.Invoke();
        if (currentHealth == 0)
        {
            OnDied.Invoke();
            PlayerDied();       
        }
        else
        {
            OnDamaged.Invoke();
        }
    }

    private void PlayerDied()
    {
        LevelManager.instance.GameOver();
        gameObject.SetActive(false);
    }
}
