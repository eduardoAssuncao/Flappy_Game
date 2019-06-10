using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Fuel : MonoBehaviour
{
    
    public Vector2 vel;
    public float inicioy;
    public float fimy;
   

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Time.deltaTime * vel);

        if (transform.position.y < fimy)
        {
            SceneManager.LoadScene("Menu");
        }
    }
    void OnCollisionEnter2D(Collision2D col)
    {
        if(col.transform.tag == "Player")
        {
            Destroy(gameObject);
        }

        if (col.transform.tag == "Obstaculo")
        {
            Destroy(gameObject);     
        }
    }
}





/*{
        if (col.transform.tag == "Player") ///if (col.gameObject.tag == "Player")
            {
            //Instantiate(fuel, transform.TransformPoint(0, 0, 0), transform.rotation);
            Instantiate(gameObject);
            Vector2 novaPosicao;
            novaPosicao.y = inicioy;
            novaPosicao.x = Random.Range(-4f, 3.5f);
            transform.position = novaPosicao;
            
        }*/

