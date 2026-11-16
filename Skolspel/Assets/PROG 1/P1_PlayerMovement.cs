using UnityEngine;
using UnityEngine.InputSystem;

public class P1_PlayerMovement : MonoBehaviour
{
    [SerializeField] private InputActionReference controls;
    [SerializeField] private float speed;

    private float currentSpeedX = 0f;
    private float currentSpeedY = 0f;

    void Update()
    {

        Vector2 input = controls.action.ReadValue<Vector2>();

        input *= speed * Time.deltaTime;

        currentSpeedX = Mathf.Lerp(currentSpeedX, input.x, Time.deltaTime);
        currentSpeedY = Mathf.Lerp(currentSpeedY, input.y, Time.deltaTime);

        transform.Translate(currentSpeedX, 0, currentSpeedY);
    }
}
