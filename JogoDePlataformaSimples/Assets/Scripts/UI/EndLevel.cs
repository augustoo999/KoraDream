using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndLevel : MonoBehaviour
{
    [SerializeField]
    private string NextScene;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent<MovimentoPlayer>(out var player))
        {
            SceneManager.LoadScene(NextScene);
        }
    }
}
