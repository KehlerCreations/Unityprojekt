using UnityEngine;
using UnityEngine.InputSystem;

public class T_FP_PlayerMovement : MonoBehaviour
{
    [Header("References")]
    [SerializeField] private Transform cameraTransform;
    [SerializeField] private InputActionReference controls;

    [Header("Settings")]
    [SerializeField] private float speed;

    void Update()
    {
        Vector2 input = controls.action.ReadValue<Vector2>();

        Vector3 forward = cameraTransform.forward;
        Vector3 right = cameraTransform.right;

        forward.y = 0f;
        right.y = 0f;

        Vector3 movement = (forward * input.y) + (right * input.x);
        movement.Normalize();

        transform.Translate(movement * speed * Time.deltaTime);
    }
}
