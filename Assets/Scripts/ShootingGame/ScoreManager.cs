using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    // ���� ���� UI
    public TextMeshProUGUI currentScoreUI;
    // ���� ����
    public int currentScore;

    // �ְ� ���� UI
    public TextMeshProUGUI bestScoreUI;
    // �ְ� ����
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
