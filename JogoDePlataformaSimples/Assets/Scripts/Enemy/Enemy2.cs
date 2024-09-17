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
        transform.Translate(Vector2.right * speed * Time.deltaTime);

        RaycastHit2D wall = Physics2D.Raycast(groundCheck.position, Vector2.left, distance);

        if (wall.collider == false)
        {
            if (isRight == true)
            {
                transform.eulerAngles = new Vector3(0, 0, 0);
                isRight = false;
            }
            else
            {
                transform.eulerAngles = new Vector3(0, 180, 0);
                isRight = true;
            }
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
