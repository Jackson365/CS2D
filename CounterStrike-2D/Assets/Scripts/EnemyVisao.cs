using UnityEngine;

public class EnemyVisao : MonoBehaviour
{
    public Transform target; // referência ao alvo
    public float visionRadius = 5f; // raio da área de visão
    public float speed = 2f; // velocidade de movimento do inimigo

    private bool isFollowing; // indica se o inimigo está seguindo o alvo

    private void Update()
    {
        // Calcula a distância entre o inimigo e o alvo
        float distanceToTarget = Vector2.Distance(transform.position, target.position);

        // Se o alvo estiver dentro do raio de visão
        if (distanceToTarget <= visionRadius)
        {
            // Define que o inimigo está seguindo o alvo
            isFollowing = true;

            // Move o inimigo em direção ao alvo
            transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);

            // Rotaciona o inimigo para olhar na direção do alvo
            Vector2 direction = target.position - transform.position;
            float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
            transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
        }
        else
        {
            // Define que o inimigo não está seguindo o alvo
            isFollowing = false;
        }
    }

    private void OnDrawGizmosSelected()
    {
        // Desenha uma esfera representando a área de visão do inimigo
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(transform.position, visionRadius);
    }
}