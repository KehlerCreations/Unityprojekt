using UnityEngine;
using UnityEngine.InputSystem;

public class T_FP_CameraRotation : MonoBehaviour
{
    [SerializeField] private Transform playerTransform;
    [SerializeField] private InputActionReference controls;
    [SerializeField] private float sensitivity;

    private float xRotation = 0;
    private float yRotation = 0;

    void Start()
    {

    }

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

        Vector3 cameraAngles = new Vector3(eulerAngles.x, eulerAngles.y, 0f);
        Vector3 playerAngles = new Vector3(0f, eulerAngles.y, 0f);

        transform.rotation = Quaternion.Euler(cameraAngles);
        playerTransform.rotation = Quaternion.Euler(playerAngles);
    }
}
