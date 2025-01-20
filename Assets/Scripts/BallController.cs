using UnityEngine;

public class BallController : MonoBehaviour
{
    [SerializeField] public float speed;
    public Rigidbody2D rb;

    void Start()
    {
        Invoke("LaunchBall", 3);
    }

    void Update()
    {
        
    }

    private void LaunchBall()
    {
        float x = Random.Range(0, 2) == 0 ? -1 : 1;
        float y = Random.Range(0, 2) == 0 ? -1 : 1;
        rb.linearVelocity = new Vector2(speed * x, speed * y);
    }
}
