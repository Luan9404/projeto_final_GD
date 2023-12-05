using UnityEngine;

public class CameraSeguir : MonoBehaviour
{
    public Transform personagem; // Refer�ncia ao transform do personagem
    public float suavizacao = 5f; // Ajuste de suaviza��o para o movimento da c�mera

    private void FixedUpdate()
    {
        if (personagem != null)
        {
            // Calcula a posi��o desejada da c�mera
            Vector3 destino = new Vector3(personagem.position.x, personagem.position.y, transform.position.z);

            // Move a c�mera suavemente em dire��o ao destino
            transform.position = Vector3.Lerp(transform.position, destino, suavizacao * Time.deltaTime);
        }
    }
}