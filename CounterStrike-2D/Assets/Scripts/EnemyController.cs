using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public Transform Player;
    public float Velocidade;
    void Update()
    {
        float _distancia = Vector2.Distance(transform.position, Player.position);
        
        if (_distancia > 1 && _distancia > 3)
        
        transform.position = Vector2.MoveTowards(transform.position, Player.position, Velocidade * Time.deltaTime);
    }
}
