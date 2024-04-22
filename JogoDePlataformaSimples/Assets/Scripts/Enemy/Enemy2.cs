using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy2 : MonoBehaviour
{
    public float speed;
    public float distance;
    public Transform groundCheck;
    public LayerMask layer;
    [SerializeField]
    private GameObject GameOverMenu;
    public Rigidbody2D rb;
    private bool isRight;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        Check();
        AndarInimigo();
    }
    void AndarInimigo()
    {
        transform.Translate(Vector2.right * speed * Time.deltaTime);
    }

    void Check()
    {
        // Lança um raio para a direita
        RaycastHit2D direita = Physics2D.Raycast(transform.position, Vector2.right, distance, layer);
        Debug.Log("Raycast Direita Detectado");
        // Lança um raio para a esquerda
        RaycastHit2D esquerda = Physics2D.Raycast(transform.position, Vector2.left, distance, layer);
        Debug.Log("Raycast Esquerdo Detectado");

        // Verifica se houve colisão com a direita
        if (direita.collider == true)
        {
            Debug.Log("Collider à direita");
            isRight = true;
            transform.eulerAngles = new Vector3(0, 0, 0);
        }

        // Verifica se houve colisão com a esquerda
        else if (esquerda.collider == true)
        {
            Debug.Log("Collider à esquerda");
            transform.eulerAngles = new Vector3(0, 180, 0);
            isRight = false;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Player") && rb.velocity.y <= 0)
        {
            GameOverMenu.SetActive(true);
            Time.timeScale = 0;
        }
    }
}
