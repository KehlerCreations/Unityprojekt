using UnityEngine;

public class T_TP_CameraMovement : MonoBehaviour
{
    [SerializeField] private Transform player;
    [SerializeField] private float trackingSpeed;


    void Update()
    {
        Vector3 newPosition = transform.position;
        newPosition = Vector3.Lerp(newPosition, player.position, trackingSpeed * Time.deltaTime);
        transform.position = newPosition;
    }
}
