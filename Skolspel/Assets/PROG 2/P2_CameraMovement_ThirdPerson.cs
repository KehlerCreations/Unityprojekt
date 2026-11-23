using UnityEngine;

public class P2_CameraMovement_ThirdPerson : MonoBehaviour
{

    [SerializeField] private Transform playerTransform;
    [SerializeField] private float trackingSpeed;

    void Start()
    {
        
    }

    void Update()
    {
        transform.position = Vector3.Lerp(transform.position, playerTransform.position, trackingSpeed * Time.deltaTime);

    }
}
