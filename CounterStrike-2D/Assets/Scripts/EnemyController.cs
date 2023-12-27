using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public GameObject player;
    public GameObject projectilePrefab;
    public float moveSpeed = 5f;
    public float shootDistance = 10f;
    public float fireRate = 1f;

    private float nextFireTime;

    void Update()
    {
        // Mover o inimigo em direção ao jogador
        Vector3 direction = player.transform.position - transform.position;
        transform.Translate(direction.normalized * moveSpeed * Time.deltaTime);
        
        // Rotacionar o inimigo para olhar em direção ao jogador
        transform.rotation = Quaternion.LookRotation(direction);

        // Verificar se o jogador está dentro do alcance de tiro
        if (direction.magnitude <= shootDistance && Time.time >= nextFireTime)
        {
            Shoot();
            nextFireTime = Time.time + 1f / fireRate; // Atualiza o tempo para o próximo tiro baseado na taxa de tiro
        }
    }

    void Shoot()
    {
        // Instanciar o projetil na posição do inimigo
        GameObject projectile = Instantiate(projectilePrefab, transform.position, transform.rotation);
        // Adicionar força ao projetil
        projectile.GetComponent<Rigidbody>().AddForce(transform.forward * 10f, ForceMode.Impulse);
    }
}


