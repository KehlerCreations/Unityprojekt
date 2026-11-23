using UnityEngine;
using UnityEngine.InputSystem;

public class P2_PlayerMovement : MonoBehaviour
{
    [Header("References")]
    [SerializeField] private InputActionReference controls;

    [Header("Settings")]
    [SerializeField] private float speed;

    void Update()
    {
        Vector2 input = controls.action.ReadValue<Vector2>();
        input *= speed * Time.deltaTime;
        transform.Translate(new Vector3(input.x, 0, input.y), Space.Self);
    }
}
