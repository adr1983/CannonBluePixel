using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreManager : MonoBehaviour
{
    public static int score;
    public Text text;
    
    void Start()
    {
        text = GetComponent<Text>();
        score = 0;
    }
    void Update()
    {
        text.text = "" + score;
    }

    public static void AddPoints(int pointsToAdd)
    {
        score += pointsToAdd; 
    }

    public static void MinusPoints(int pointsToMinus)
    {
        score -= pointsToMinus;
    }
}