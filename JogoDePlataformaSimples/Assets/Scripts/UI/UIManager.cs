using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
    public static UIManager Instance;
    [SerializeField]
    private TextMeshProUGUI Coins;

    private void Awake()
    {
        if (UIManager.Instance == null)
        {
            UIManager.Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }
    private void Start()
    {
        UpdateText();
    }

    public void UpdateText()
    {
        Coins.text = $"{ScoreManager.Instance.ContarPontos}";
    }
}
