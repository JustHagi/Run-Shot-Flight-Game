using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    public static Score instance;
    [SerializeField] private TextMeshProUGUI _currenScoreText;
    [SerializeField] private TextMeshProUGUI _highScoreText;

    private int _score;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        
    }
    private void Start()
    {
        _currenScoreText.text = "Skor : " + _score.ToString();
        _highScoreText.text = "En Yüksek Skor : " + PlayerPrefs.GetInt("HighScore", 0).ToString();
        UpdateHighScore();
    }

    void UpdateHighScore()
    {
        if(_score> PlayerPrefs.GetInt("HighScore"))
        {
            PlayerPrefs.SetInt("HighScore", _score);
            _highScoreText.text = "En Yüksek Skor : " + _score.ToString();
        }
    }
    public void UpdateScore()
    {
        _score++;
        _currenScoreText.text = "Skor : " + _score.ToString();
        UpdateHighScore();
    }
}
