using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class MovimentarComInputEixoXRigidbody2D : MonoBehaviour
{
    public bool viraSprite;
    public Vector2 entrada;
    private Velocidade velocidadeComponent;
    private SpriteRenderer sr;
    private Animator animator;
    public string nomeParametroVelocidade;
    private Rigidbody2D rb2D;
    private PlayerInput pi;

    void Start()
    {
        if (!TryGetComponent<Velocidade>(out velocidadeComponent))
            print("Adicione o componente <color=orange>Velocidade</color> ao GameObject.");

        sr = GetComponent<SpriteRenderer>();
        animator = GetComponent<Animator>();
        rb2D = GetComponent<Rigidbody2D>();
        pi = GetComponent<PlayerInput>();

        if (pi == null)
            StartCoroutine(ObtemEntradaEixos());
    }

    public void ObtemEntrada(InputAction.CallbackContext contexto)
    {
        entrada = contexto.ReadValue<Vector2>();

        if (animator != null)
            animator.SetFloat(nomeParametroVelocidade, Mathf.Abs(entrada.x));

        if (sr != null && viraSprite)
            if (entrada.x < 0)
                sr.flipX = true;
            else if (entrada.x > 0)
                sr.flipX = false;
    }

    void FixedUpdate()
    {
        if(Input.GetButtonDown("Jump"))
        {
            print(Vector2.up);
            rb2D.velocity = Vector2.up * 20;
        }
      
        rb2D.velocity = new Vector2(entrada.x * velocidadeComponent.GetVelocidade(), rb2D.velocity.y);

    }

    IEnumerator ObtemEntradaEixos()
    {
        while (true)
        {
            entrada.x = Input.GetAxisRaw("Horizontal");

            if (animator != null)
                animator.SetFloat(nomeParametroVelocidade, Mathf.Abs(entrada.x));

            if (sr != null && viraSprite)
                if (entrada.x < 0)
                    sr.flipX = true;
                else if (entrada.x > 0)
                    sr.flipX = false;

            yield return new WaitForEndOfFrame();
        }
    }
}
