using UnityEngine;
using UnityEngine.InputSystem;

public class P2_PlayerMovement : MonoBehaviour
{
    [Header("References")]
    [SerializeField] private InputActionReference controls;
    [SerializeField] private Rigidbody rigidBody;
    [SerializeField] private LayerMask wallLayer;

    [Header("Settings")]
    [SerializeField] private float speed;
    [SerializeField] private float jumpDistance;
    [SerializeField] private float jumpForce;

    void Update()
    {
        Vector2 input = controls.action.ReadValue<Vector2>();
        Vector3 movement = new Vector3(input.x, 0, input.y) * speed * Time.deltaTime;
        rigidBody.AddForce(movement);

        CheckForObstacle();
    }

    private void CheckForObstacle()
    {
        if (!Physics.Raycast(transform.position, Vector3.down, .1f, wallLayer)) return;

        Vector3 direction = new Vector3(rigidBody.linearVelocity.x, 0, rigidBody.linearVelocity.z).normalized;

        float distance = direction.magnitude * jumpDistance;
        if (Physics.Raycast(transform.position + Vector3.up, direction, distance, wallLayer))
        {
            rigidBody.AddForce(new Vector3(0, jumpForce, 0));
        }
    }
}
