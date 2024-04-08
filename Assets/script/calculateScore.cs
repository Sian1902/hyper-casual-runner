using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class calculateScore : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI scoreText;
    [SerializeField] private TextMeshProUGUI multiplierText;
    [SerializeField] private TextMeshProUGUI finalScoreText;
    [SerializeField] private float threshold = 0.05f;
    private int count=0;
    void Start()
    {
        scoreText.text= CollisionHandler.s_Score.ToString();
        multiplierText.text=$"X {end.s_Multiplier.ToString()}";
        finalScoreText.text= count.ToString();
        StartCoroutine(counter());
    }
    IEnumerator counter()
    {
        for(int i=0;i<CollisionHandler.s_Score*end.s_Multiplier;i++) {
        count++;
            finalScoreText.text = count.ToString();
            yield return new WaitForSeconds(threshold);
        }
    }
    public void restart()
    {
        CollisionHandler.s_Score = 0;
        end.s_Multiplier = 1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    public void exit()
    {
        Application.Quit();
    }

    
}
