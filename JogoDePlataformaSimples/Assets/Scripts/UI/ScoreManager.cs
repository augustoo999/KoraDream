using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager Instance;
    public int ContarPontos;

    private void Awake()
    {
        if (ScoreManager.Instance == null)
        {
            ScoreManager.Instance = this;
            DontDestroyOnLoad((this.gameObject));
        }
        else
        {
            Destroy(gameObject);
        }
    }
    public void SomarPontos(int Pontos)
    {
        ContarPontos += Pontos;
        UIManager.Instance.UpdateText();
    }
}
