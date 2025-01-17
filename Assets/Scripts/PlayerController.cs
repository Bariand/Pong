using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    //"InputSystem_Actions" é o nome da "Input Action Asset", ou seja, da lista de input que fizemos no início
    private InputSystem_Actions playerControls;
    private Rigidbody2D rb;
    [SerializeField] private float moveSpeed;

    void Start()
    {
        playerControls = new InputSystem_Actions();
        rb = GetComponent<Rigidbody2D>();
    }

    private void OnMove(InputValue inputValue) 
    {   
        rb.linearVelocity = inputValue.Get<Vector2>() * moveSpeed;
        print("OnMove foi ativado");
    }
}
