using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
    public static UIManager Instance;

    [SerializeField] private TextMeshProUGUI scoreText;
    private int score = 0;

    private void Awake()
    {
        Instance = this;
    }

    public void AddPoint()
    {
        score++;
        scoreText.text = "Points: " + score;
    }
}
