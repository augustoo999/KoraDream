using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy2 : MonoBehaviour
{
    public float speed;
    public float distance;
    bool isRight = true;
    public Transform groundCheck;
    public LayerMask layer;
    [SerializeField]
    private GameObject GameOverMenu;
    public Rigidbody2D rb;

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
        RaycastHit2D direita = Physics2D.Raycast(transform.position, Vector2.right, distance, layer);
        RaycastHit2D esquerda = Physics2D.Raycast(transform.position, Vector2.left, distance, layer);
        if (direita.collider == true)
        { 
            isRight = true;
            transform.eulerAngles = new Vector3(0, 180, 0);
        }
        
        else if (esquerda.collider == true)
        {
            transform.eulerAngles = new Vector3(0, 0, 0);
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
