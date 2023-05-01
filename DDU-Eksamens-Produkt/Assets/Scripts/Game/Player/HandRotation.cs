using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class HandRotation : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private float rotationSpeed;

    private Vector2 movementInput;
    private Rigidbody2D rigidbody;
    private Vector2 smoothedMovementInput;
    private Vector2 movementInputSmoothVelocity;
    private GameObject parent;

    private void Awake()
    {
        rigidbody = transform.parent.GetComponent<Rigidbody2D>();
        parent = transform.parent.gameObject;
    }

    private void FixedUpdate()
    {
        SetPlayerVelocity();
        RotateInDirectionOfInput();
    }

    private void SetPlayerVelocity()
    {
        smoothedMovementInput = Vector2.SmoothDamp(
                    smoothedMovementInput,
                    movementInput,
                    ref movementInputSmoothVelocity,
                    0.1f);

        rigidbody.velocity = smoothedMovementInput * speed;
    }

    private void RotateInDirectionOfInput()
    {
       
        if (movementInput != Vector2.zero)
        {
            Quaternion targetRotation = Quaternion.LookRotation(parent.transform.forward, smoothedMovementInput);
            Quaternion rotation = Quaternion.RotateTowards(transform.rotation, targetRotation, rotationSpeed * Time.deltaTime);

            rigidbody.MoveRotation(rotation);
            Debug.Log(rotation);
        }
    }

    private void OnMove(InputValue inputValue)
    {
        movementInput = inputValue.Get<Vector2>();
    }
}
