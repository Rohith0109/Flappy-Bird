using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreUpdate : MonoBehaviour
{
    public static ScoreUpdate instance;

    [SerializeField] TextMeshProUGUI _currentScoreText;
    [SerializeField] TextMeshProUGUI _highScoreText;

    private int _score;

    // Start is called before the first frame update
    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    private void Start()
    {
        _currentScoreText.text = _score.ToString();
        _highScoreText.text = PlayerPrefs.GetInt("Higher Score", 0).ToString();
        updateHighScore();
    }

    // Update is called once per frame

    void updateHighScore()
    {
        if (_score > PlayerPrefs.GetInt("Higher Score"))
        {
            PlayerPrefs.SetInt("Higher Score", _score);
            _highScoreText.text = _score.ToString();
        }
    }

    public void updateScore()
    {
        _score++;
        _currentScoreText.text = _score.ToString();
        updateHighScore();

    }
}
