using UnityEngine;

public class CameraSeguir : MonoBehaviour
{
    public Transform personagem; // Referência ao transform do personagem
    public float suavizacao = 5f; // Ajuste de suavização para o movimento da câmera

    private void FixedUpdate()
    {
        if (personagem != null)
        {
            // Calcula a posição desejada da câmera
            Vector3 destino = new Vector3(personagem.position.x, personagem.position.y, transform.position.z);

            // Move a câmera suavemente em direção ao destino
            transform.position = Vector3.Lerp(transform.position, destino, suavizacao * Time.deltaTime);
        }
    }
}