using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine;

public class Flappy : MonoBehaviour
{
	public Rigidbody2D rigid;
	public Vector2 vel;
    public Text text;
    public int points = 0;
    public float sidewaysForce = 10f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
		if(Input.GetKeyDown(KeyCode.Space))
		{
			rigid.velocity = vel;
		}
        if (Input.GetKey(KeyCode.D))
        {
            rigid.AddForce(new Vector2 (sidewaysForce, 0 * Time.deltaTime));
            Debug.Log("Apertei");
        }
        if (Input.GetKey(KeyCode.A))
        {
            rigid.AddForce(new Vector2(-sidewaysForce, 0 * Time.deltaTime));
            Debug.Log("Apertei");
        }
    }
	
	void OnCollisionEnter2D(Collision2D col )
	{
		Debug.Log(col.transform.name);
		if(col.transform.tag == "Obstaculo")
		{
			SceneManager.LoadScene(0);
		}

        if (col.transform.tag == "Fuel")
        {
            points = points + 10; // incrementa pontuacao
            Destroy(col.gameObject); // destroi o gameobject do item
            Debug.Log("Points:R$ " + points); // imprime uma mensagem no console com a pontuacao
        }

        if (col.transform.tag == "Fuel")
        {
            text.text = points.ToString();
        }
	    
    }
}
