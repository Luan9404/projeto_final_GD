using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ExemploGUI : MonoBehaviour
{
    public void AbrirFecharCanvas(GameObject go)
    {
        go.SetActive(!go.activeSelf);
    }

    public void CarregarFase(string texto)
    {
        SceneManager.LoadScene(texto);
    }

    public void FecharJogo()
    {
        Application.Quit();
    }
}
