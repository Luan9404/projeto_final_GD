using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Events;

public class GameManager : MonoBehaviour
{
    public static GameManager gm = null;

    public int pontuacao;
    public int vida;
    public TMP_Text pontuacaoText;
    public TMP_Text vidaText;

    private void Awake()
    {
        if (gm == null)
            gm = this;
        else
            Destroy(gameObject);

        DontDestroyOnLoad(gameObject);
    }

    private void Start()
    {
        pontuacao = 0;
        vida = 3;

    }

    public void SetPontuacao(int pont)
    {
        pontuacao = pont;
        pontuacaoText.text = pontuacao.ToString();
    }

    public void VariacaoPontuacao(int pont)
    {
        pontuacao += pont;
        pontuacaoText.text = pontuacao.ToString();
    }

    public void VariacaoVida(int vid)
    {
        vida = vid;
        vidaText.text = vida.ToString();
    }

}
