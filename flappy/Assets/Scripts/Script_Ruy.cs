using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script_Ruy : MonoBehaviour
{
    public Transform[] spawnPoint;
    public GameObject enemy;
    public int seed;
    public float Timer;
    public float cooldown;
    //public float speed = 3f;
 
  
    // Start is called before the first frame update
    void Start()
    {
        Timer = 0;      
        Random.InitState(seed);
    }

    // Update is called once per frame
    void Update()
    {
        //transform.Translate(new Vector2(0, -speed * Time.deltaTime));
        Timer += Time.deltaTime;
        if (Timer >= cooldown)
        {
            int randowPoint = Random.Range(0,spawnPoint.Length);
            Instantiate(enemy, spawnPoint[seed].position,spawnPoint[seed].rotation);
            Timer = 0.0f;
        }
    }
}
