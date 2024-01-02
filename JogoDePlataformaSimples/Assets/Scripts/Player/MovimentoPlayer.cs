using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class MovimentoPlayer : MonoBehaviour
{
    public TextMeshProUGUI MoedaTxt;
    //private float Moeda;
    public float speed;
    public Rigidbody2D rb;
    private float direction;
    public float ForcaPulo;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        //Moeda = 0;
    }

    // Update is called once per frame
    void Update()
    {
        Andar();
        Pulo();
        //MoedaTxt.text = Moeda.ToString();
    }

    //Andar do Player
    public void Andar()
    {
        direction = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(direction * speed, rb.velocity.y);
        
    }

    //Pulo do Player
    public void Pulo()
    {
        if (Input.GetButtonDown("Jump"))
        {
            rb.velocity = Vector2.up * ForcaPulo;
        }
    }

    //private void OnTriggerEnter2D(Collider2D col)
    //{
    //    if (col.gameObject.CompareTag("Coin"))
    //    {
    //        Moeda = Moeda + 1;
    //        Destroy(col.gameObject);
    //    }
    //}
}
