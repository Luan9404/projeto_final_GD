using UnityEngine;

public class CameraSeguir : MonoBehaviour
{
    public Transform personagem;
    public float suavizacao = 5f; 

    private void FixedUpdate()
    {
        if (personagem != null)
        {
            Vector3 destino = new Vector3(personagem.position.x + 4, personagem.position.y, transform.position.z);

            transform.position = Vector3.Lerp(transform.position, destino, suavizacao * Time.deltaTime);
        }
    }
}