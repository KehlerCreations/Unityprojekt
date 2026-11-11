using UnityEngine;
using UnityEngine.InputSystem;

public class T_TP_CameraRotation : MonoBehaviour
{
    [SerializeField] private InputActionReference controls;
    [SerializeField] private float turnSpeed;

    private float xAngle;
    private float yAngle;

    void Update()
    {
        Vector2 input = controls.action.ReadValue<Vector2>();
        float horizontalRotation = input.x * turnSpeed;
        float verticalRotation = -(input.y * turnSpeed);

        xAngle += verticalRotation;
        yAngle += horizontalRotation;

        xAngle = Mathf.Clamp(xAngle, -85, 85);

        Vector3 newRotation = new Vector3(xAngle, yAngle, 0f);
        transform.rotation = Quaternion.Euler(newRotation);
    }
}
