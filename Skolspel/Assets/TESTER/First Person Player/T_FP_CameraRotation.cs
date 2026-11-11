using UnityEngine;
using UnityEngine.InputSystem;

public class T_FP_CameraRotation : MonoBehaviour
{

    [SerializeField] private InputActionReference controls;
    [SerializeField] private float sensitivity;

    private float xRotation = 0;
    private float yRotation = 0;

    void Update()
    {
        Vector2 delta = controls.action.ReadValue<Vector2>();
        Vector3 rotation = new Vector3(delta.x, delta.y, 0) * sensitivity;

        xRotation -= rotation.y;
        yRotation += rotation.x;
        xRotation = Mathf.Clamp(xRotation, -85, 85);

        Vector3 eulerAngles = transform.rotation.eulerAngles;
        eulerAngles.x = xRotation;
        eulerAngles.y = yRotation;
        transform.rotation = Quaternion.Euler(eulerAngles);

    }
}
