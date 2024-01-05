using UnityEngine;

public class BalaEnemy : MonoBehaviour
{
    public GameObject objetoPrefab;
    public Transform pontoInstanciacao;
    public float campoDeVisao = 30f;
    public float alcanceCampoDeVisao = 10f;

    private void Update()
    {
        // Verifica se o jogador está no campo de visão
        Vector3 direcao = pontoInstanciacao.position - transform.position;
        float angulo = Vector3.Angle(direcao, transform.forward);

        if (angulo < campoDeVisao)
        {
            RaycastHit hit;

            if (Physics.Raycast(transform.position, direcao, out hit, alcanceCampoDeVisao))
            {
                if (hit.collider.CompareTag("Player"))
                {
                    // Instancia o objeto
                    Instantiate(objetoPrefab, pontoInstanciacao.position, pontoInstanciacao.rotation);
                }
            }
        }
    }
}