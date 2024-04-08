using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class end : MonoBehaviour
{
    public static int s_Multiplier=1;
    [SerializeField] int localMultiplier;
    [SerializeField] GameObject endPanel;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("player"))
        {
            if (localMultiplier > s_Multiplier)
            {
                s_Multiplier = localMultiplier;
            }
            endPanel.SetActive(true);   
        }
    }
    
}
