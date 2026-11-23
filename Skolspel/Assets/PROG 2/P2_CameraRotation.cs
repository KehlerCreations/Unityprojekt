using UnityEngine;
using UnityEngine.InputSystem;

public class P2_CameraRotation : MonoBehaviour
{

    [SerializeField] private InputActionReference controls;
    [SerializeField] private Transform playerTransform;
    [SerializeField] private float rotationSpeed;

    private float xRotation = 0;
    private float yRotation = 0;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {
        Vector2 input = controls.action.ReadValue<Vector2>();
        Vector3 eulerAngles = transform.rotation.eulerAngles;

        xRotation -= input.y * rotationSpeed;
        yRotation += input.x * rotationSpeed;
        xRotation = Mathf.Clamp(xRotation, -90, 90);

        eulerAngles.x = xRotation;
        eulerAngles.y = yRotation;

        transform.rotation = Quaternion.Euler(eulerAngles);

        Vector3 newPlayerRotation = transform.rotation.eulerAngles;
        newPlayerRotation.x = 0;
        newPlayerRotation.z = 0;
        playerTransform.rotation = Quaternion.Euler(newPlayerRotation);
    }
}
