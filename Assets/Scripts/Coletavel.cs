using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coletavel : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            GameManager gm = other.GetComponent<GameManager>();
            // Adicione lógica de coleta aqui (por exemplo, incrementar o contador, reproduzir som, etc.)
            Collect(gm);
        }
    }

    void Collect(GameManager gm)
    {
        // Adicione lógica de coleta aqui
        // Por exemplo, você pode incrementar um contador global de coletáveis
        gm.VariacaoPontuacao(1);
        // Destruir o objeto coletável
        Destroy(gameObject);
    }

}
