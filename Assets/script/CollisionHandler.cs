using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CollisionHandler : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI scoreText; 
    private Rigidbody rb;
    private BoxCollider col;
    public static int s_Score = 0;
    private float scaleVal = 1f;

    private void Start()
    {
        
        col = GetComponent<BoxCollider>();
       scoreText.text= s_Score.ToString();
    }
    private void OnTriggerEnter(Collider other)
    {
       
        if (other.gameObject.CompareTag("collectable"))
        {
            Destroy(other.gameObject);
            scaleVal += 0.25f;
            s_Score += 1;
            scoreText.text = s_Score.ToString();
            transform.DOScaleY(scaleVal, 1);
            Debug.Log(scaleVal);
        }
        if (other.gameObject.CompareTag("hardle"))
        {
            if (scaleVal > 0.25f)
            {
                other.gameObject.GetComponent<Collider>().enabled = false;
                scaleVal -= 0.25f;
                transform.DOScaleY(scaleVal, 1);
                Debug.Log(scaleVal);
            }
            else
            {
              s_Score = 0;
              scaleVal = 1f;
              transform.DOKill();
              SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            }
            if (s_Score > 0)
            {
                s_Score -= 1;
                scoreText.text = s_Score.ToString();

            }
        }
  
    }
 
  

}
