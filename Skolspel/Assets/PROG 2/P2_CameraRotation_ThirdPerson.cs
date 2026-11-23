using UnityEngine;
using UnityEngine.InputSystem;

public class P2_CameraRotation_ThirdPerson : MonoBehaviour
{

    [SerializeField] private InputActionReference controls;
    [SerializeField] private Transform playerTransform;

    private float xRotation = 0f;
    private float yRotation = 0f;

    void Start()
    {
        
    }

    void Update()
    {
        Vector2 input = controls.action.ReadValue<Vector2>();

        xRotation -= input.y;
        yRotation += input.x;

        xRotation = Mathf.Clamp(xRotation, -10f, 60f);

        Vector3 eulerAngles = transform.rotation.eulerAngles;
        eulerAngles.x = xRotation;
        eulerAngles.y = yRotation;
        transform.rotation = Quaternion.Euler(eulerAngles);

        Vector3 playerRotation = eulerAngles;
        playerRotation.x = 0f;
        playerRotation.z = 0f;
        playerTransform.rotation = Quaternion.Euler(playerRotation);
    }
}
