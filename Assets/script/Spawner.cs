using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner: MonoBehaviour
{
    [SerializeField] private GameObject hardlePrefap;
    [SerializeField] private int hardleCount;
    [SerializeField] private Vector2 minMaxXpos;
    [SerializeField] private float initialPos=10f;
    [SerializeField] private float increment=11;
    private GameObject instantiated;
    private void Start()
    {
        for(int i = 0; i < hardleCount; i++)
        {
            Vector3 spawnPos = new Vector3(Random.Range(minMaxXpos.x,minMaxXpos.y), 0.1f, initialPos);
            instantiated= Instantiate(hardlePrefap, spawnPos, Quaternion.identity);
            instantiated.transform.parent = transform;
            instantiated.transform.localPosition = spawnPos;
            initialPos += increment;
        }
    }
}
