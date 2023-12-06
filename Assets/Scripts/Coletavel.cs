using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coletavel : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            GameManager gm = GameObject.FindWithTag("GameController").GetComponent<GameManager>();
            Collect(gm);
        }
    }

    void Collect(GameManager gm)
    {
        gm.VariacaoPontuacao(1);
        Destroy(gameObject);
    }

}
