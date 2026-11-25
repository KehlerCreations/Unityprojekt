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

        Vector3 delta = new Vector3(input.x, 0f, input.y);

        transform.Translate(delta * speed * Time.deltaTime);
    }
}
