using UnityEngine;

public class P1_Move : MonoBehaviour
{

    [SerializeField] private float xSpeed;

    void Start()
    {
        Debug.Log("Move har startats");
    }

    void Update()
    {
        transform.Translate(xSpeed * Time.deltaTime, 0, 0);
    }
}
