using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class T_TP_PlayerMovement : MonoBehaviour
{
    [Header("References")]
    [SerializeField] private InputActionReference moveControls;
    [SerializeField] private Transform cameraBoom;

    [Header("Settings")]
    [SerializeField] private float moveSpeed;
    [SerializeField] private float turnSpeed;

    void Start()
    {
        
    }

    void Update()
    {
        Move();
        Turn();
    }

    private void Move()
    {
        Vector2 input = moveControls.action.ReadValue<Vector2>();
        Vector3 movement = new Vector3(input.x, 0, input.y) * moveSpeed;
        transform.Translate(movement * Time.deltaTime, Space.Self);
    }

    private void Turn()
    {
        Vector3 targetEuler = cameraBoom.eulerAngles;
        targetEuler.x = 0f;
        targetEuler.z = 0f;

        Quaternion targetRotation = Quaternion.Euler(targetEuler);

        transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, turnSpeed * Time.deltaTime);
    }
}
