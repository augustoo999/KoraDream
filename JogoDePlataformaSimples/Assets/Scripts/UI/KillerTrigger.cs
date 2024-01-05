using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class KillerTrigger : MonoBehaviour
{
    [SerializeField]
    private GameObject GameOverMenu;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent<MovimentoPlayer>(out var player))
        {
            GameOverMenu.SetActive(true);
            Time.timeScale = 0;
            ScoreManager.Instance.ContarPontos = 0;
        }
    }
}
