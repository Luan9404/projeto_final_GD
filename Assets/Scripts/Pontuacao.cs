using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pontuacao : MonoBehaviour
{
    public int pontuacao;

    private void OnDestroy()
    {
        if (GameManager.gm != null)
            GameManager.gm.GetComponent<GameManager>().VariacaoPontuacao(pontuacao);
    }
}
