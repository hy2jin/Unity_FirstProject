using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    // 현재 점수 UI
    public TextMeshProUGUI currentScoreUI;
    // 현재 점수
    public int currentScore;

    // 최고 점수 UI
    public TextMeshProUGUI bestScoreUI;
    // 최고 점수
    public int bestScore;

    // Start is called before the first frame update
    void Start()
    {
        currentScore = 0;
        bestScore = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
