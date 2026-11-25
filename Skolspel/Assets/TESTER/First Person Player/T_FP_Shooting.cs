using UnityEngine;
using UnityEngine.InputSystem;

public class T_FP_Shooting : MonoBehaviour
{
    [SerializeField] private Transform cameraTransform;
    [SerializeField] private InputActionReference controls;
    [SerializeField] private GameObject bullet;
    [SerializeField] private Vector3 spawnOffset;

    void Update()
    {
        bool input = controls.action.WasPressedThisFrame();

        if(input)
        {
            Vector3 position = cameraTransform.TransformPoint(spawnOffset);
            Quaternion rotation = cameraTransform.rotation;
            Instantiate(bullet, position, rotation);
        }
    }


}
