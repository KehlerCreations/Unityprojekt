using UnityEngine;
using UnityEngine.InputSystem;

public class P1_PlayerMovement : MonoBehaviour
{
    [SerializeField] private InputActionReference controls;
    [SerializeField] private float speed;
    [SerializeField] private float smoothness;

    private float currentSpeedX = 0f;
    private float currentSpeedY = 0f;

    void Update()
    {
        Vector2 input = controls.action.ReadValue<Vector2>();

        input *= speed * Time.deltaTime;

        currentSpeedX = Mathf.Lerp(currentSpeedX, input.x, smoothness * Time.deltaTime);
        currentSpeedY = Mathf.Lerp(currentSpeedY, input.y, smoothness * Time.deltaTime);

        transform.Translate(currentSpeedX, 0, currentSpeedY, Space.Self);
    }
}
