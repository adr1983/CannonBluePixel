using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    public GameObject winPanel;
    public GameObject losePanel;

    void Update()
    {
        if (ScoreManager.score == 10)
        {
            winPanel.SetActive(true);
        }

        if (ScoreManager.score == -1)
        {
            losePanel.SetActive(true);
        }
    }
    public void Restart()
    {
        SceneManager.LoadScene("Main");
    }
}