using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instantiate_Rock : MonoBehaviour
{
    
    public GameObject rock;
    public int seed;
    private float instantiationTimer = 2f;
    
    // Update is called once per frame
    void Update()
    {
        CreatePrefab();  
    }

    void CreatePrefab()
    {
        instantiationTimer -= Time.deltaTime;

        if (instantiationTimer <= 0)
        {
            //Instantiate(rock, spawn.position,Quaternion.identity);
            instantiationTimer = 2f;
        }
    }
}
