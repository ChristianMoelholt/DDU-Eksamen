using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projektile : MonoBehaviour
{
    [HideInInspector] public float ProjektileVelocity;
    [SerializeField] Rigidbody2D rb;

    private void Start()
    {
        Destroy(GameObject, 4f);
    }

    private void FixedUpdate()
    {
        rb.velocity = transform.up * ProjektileVelocity;
    }
}
