using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody2D rb;
    [SerializeField] private float moveSpeed;
    [SerializeField] private bool isPlayerOne;  // Define se este pad é o Player 1

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        float moveInput = 0;

        // Verificar se este pad é o Player 1 ou Player 2
        if (isPlayerOne)
        {
            // Controles para o Player 1 (W e S)
            if (Input.GetKey(KeyCode.W))
            {
                moveInput = 1;
            }
            else if (Input.GetKey(KeyCode.S))
            {
                moveInput = -1;
            }
        }
        else
        {
            // Controles para o Player 2 (Setas para cima e para baixo)
            if (Input.GetKey(KeyCode.UpArrow))
            {
                moveInput = 1;
            }
            else if (Input.GetKey(KeyCode.DownArrow))
            {
                moveInput = -1;
            }
        }

        // Aplicar o movimento ao Rigidbody
        rb.linearVelocity = new Vector2(0, moveInput * moveSpeed);
    }
}