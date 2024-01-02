using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Coins : MonoBehaviour
{
    [SerializeField]
    private int points;
    private int Moeda;

    private void Start()
    {
        Moeda = 1;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            ScoreManager.Instance.SomarPontos(Moeda);
            Destroy(gameObject);

        }
    }
}
