using UnityEngine;

public class Move : MonoBehaviour
{

    [SerializeField] private float xSpeed;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("Move har startats");
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(xSpeed * Time.deltaTime, 0, 0);
    }
}
