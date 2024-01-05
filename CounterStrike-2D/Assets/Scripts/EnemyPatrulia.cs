using UnityEngine;

public class EnemyPatrulia : MonoBehaviour
{
    // Start is called before the first frame update

    public float Velocidade;
    public Transform posicao;
    public float TempoEspera;

    public float xmin, xmax, ymin, ymax;

    
    private float Tempo;
    
    void Start()
    {
        posicao.position = new Vector2(Random.Range(xmin, xmax), Random.Range(ymin, ymax));
        Tempo = TempoEspera;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position =
            Vector2.MoveTowards(transform.position, posicao.position, Velocidade * Time.deltaTime);

        float _dist = Vector2.Distance(transform.position, posicao.position);

        if (_dist <- .2f)
        {
            
        }

        if (Tempo <= 0)
        {
            posicao.position = new Vector2(Random.Range(xmin, xmax), Random.Range(ymin, ymax));
            Tempo = TempoEspera;
        }
        else
        {
            Tempo -= Time.deltaTime;
        }
    }
}
