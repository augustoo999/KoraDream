using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class MovimentoPlayer : MonoBehaviour
{
    public TextMeshProUGUI MoedaTxt;
    public float speed;
    private bool isGround = true;
    public Rigidbody2D rb;
    private float _direction;
    public float ForcaPulo;
    private bool _IsJumping;
    [SerializeField]
    private string Reset;

    public float direction
    {
        get { return _direction; }
        set { _direction = value; }
    }

    public bool IsJumping 
    {
        get { return _IsJumping; }
        set { _IsJumping = value; }
    }

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        OnInput();
        Pulo();
    }

    private void FixedUpdate()
    {
        Andar();
    }

    #region Movement

    void OnInput()
    {
      
    }

    public void Andar()
    {
        direction = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(direction * speed, rb.velocity.y);
    }

    public void Pulo()
    {
        if (isGround && Input.GetButtonDown("Jump"))
        {
            rb.velocity = Vector2.up * ForcaPulo;
            
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            isGround = true;
            _IsJumping = false;
        }

    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            isGround = false;
            _IsJumping = true;
        }
    }

    #endregion

}