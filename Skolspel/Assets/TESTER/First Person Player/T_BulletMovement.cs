using UnityEngine;

public class T_BulletMovement : MonoBehaviour
{

    [SerializeField] private float speed;
    [SerializeField] private float lifetime;

    void Start()
    {
        
    }

    void Update()
    {
        transform.Translate(new Vector3(0f, 0f, speed * Time.deltaTime));
        lifetime -= Time.deltaTime;
        if (lifetime < 0) Destroy(gameObject);
    }
}
