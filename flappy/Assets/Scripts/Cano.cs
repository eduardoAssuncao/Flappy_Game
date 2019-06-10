using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cano : MonoBehaviour
{
	public float inicioy;
	public float fimy;
	public Vector2 vel;
    public GameObject rock;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
		transform.Translate(Time.deltaTime * vel);
        
		if(transform.position.y < fimy)
		{
           // Instantiate(rock, transform.TransformPoint(0, 0, 0), transform.rotation);
            Vector2 novaPosicao;
			novaPosicao.y = inicioy;
			novaPosicao.x = Random.Range(-3.8f, 3.8f);
			transform.position = novaPosicao;
			vel.x = vel.x - 0.5f;

        }
    }
}
