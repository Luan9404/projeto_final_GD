using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using static UnityEditor.PlayerSettings;

public class EntradaVetor2D : MonoBehaviour
{
    public Vector2 entrada;
    private Animator animator;
    private SpriteRenderer spriteRend;
    private Rigidbody2D rb;

    void Start()
    {
        animator = GetComponent<Animator>();
        spriteRend = GetComponent<SpriteRenderer>();
        rb = GetComponent<Rigidbody2D>();
    }

    public void ObtemEntrada(InputAction.CallbackContext contexto)
    {
        entrada = contexto.ReadValue<Vector2>();

        animator.SetFloat("velocidade", Mathf.Abs(entrada.x));
        spriteRend.flipX = entrada.x < 0 ? true : false;
    }

    public Vector2 GetEntrada()
    {
        return entrada;
    }

    void Update()
    {
        transform.Translate(entrada.x * 5.0f
            * Time.deltaTime * transform.right);
    }

    public void Pular()
    {
        rb.AddForce(new Vector2(0.0f, 250.0f));
    }
}
