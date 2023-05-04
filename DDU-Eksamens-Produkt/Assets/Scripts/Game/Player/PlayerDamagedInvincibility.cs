using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class PlayerDamagedInvincibility : MonoBehaviour
{
    [SerializeField] float invincibilityDuration;
    private InvincibilityController invincibilityController;
    Animator animator;

    private void Awake()
    {
        invincibilityController = GetComponent<InvincibilityController>();
        animator = GetComponent<Animator>();
    }

    public void StartInvincibility()
    {
        invincibilityController.StartInvincibility(invincibilityDuration);
        animator.SetTrigger("Damaged");
    }
}
