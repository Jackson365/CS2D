using UnityEngine;

public class EnemyPatrulia : MonoBehaviour
{
    // Start is called before the first frame update

    public float Velocidade;
    public Transform[] posicao;
    public float TempoEspera;

    private int Randomica;
    private float Tempo;
    
    void Start()
    {
        Randomica = Random.Range(0, posicao.Length);
        Tempo = TempoEspera;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position =
            Vector2.MoveTowards(transform.position, posicao[Randomica].position, Velocidade * Time.deltaTime);

        float _dist = Vector2.Distance(transform.position, posicao[Randomica].position);

        if (_dist <- .2f)
        {
            
        }

        if (Tempo <= 0)
        {
            Randomica = Random.Range(0, posicao.Length);
            Tempo = TempoEspera;
        }
        else
        {
            Tempo -= Time.deltaTime;
        }
    }
}
