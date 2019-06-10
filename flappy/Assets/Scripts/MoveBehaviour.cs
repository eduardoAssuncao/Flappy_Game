using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine;

public class MoveBehaviour : MonoBehaviour
{
    
    
    public float sidewaysForce = 3f;
    public float topwaysForce = 5f;
    public Text text;
    public int points = 0;
    MoveBehaviour player;
    Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        player = GetComponent<MoveBehaviour>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        /*if (Input.GetKeyDown(KeyCode.Space))
        {
            rigid.velocity = vel;
        }*/
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(new Vector2(0, topwaysForce * Time.deltaTime));
            Debug.Log("Apertei");
        }

        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(new Vector2(0, -topwaysForce * Time.deltaTime));
            Debug.Log("Apertei");
        }

        if (Input.GetKey(KeyCode.D))
        {
            anim.SetBool("MovR", true);
            transform.Translate(new Vector2(sidewaysForce, 0 * Time.deltaTime));
            Debug.Log("Apertei");
        }

        if (Input.GetKeyUp(KeyCode.D))
        {
            anim.SetBool("MovR", false);
            transform.Translate(new Vector2(sidewaysForce, 0 * Time.deltaTime));
            Debug.Log("Apertei");
        }

        if (Input.GetKey(KeyCode.A))
        {
            anim.SetBool("MovL", true);
            transform.Translate(new Vector2(-sidewaysForce, 0 * Time.deltaTime));
            Debug.Log("Apertei");
        }

        if (Input.GetKeyUp(KeyCode.A))
        {
            anim.SetBool("MovL", false);
            transform.Translate(new Vector2(-sidewaysForce, 0 * Time.deltaTime));
            Debug.Log("Apertei");
        }

    }

    void OnCollisionEnter2D(Collision2D col)
    {
        Debug.Log(col.transform.name);
        if (col.transform.tag == "Obstaculo")
        {
            SceneManager.LoadScene(1);
        }

        if (col.gameObject.tag == "Fuel")
        {
            points = points + 10; // incrementa pontuacao       
            text.text = points.ToString();
            Debug.Log("Points:R$ " + points); // imprime uma mensagem no console com a pontuacao
        }

        /*if (col.transform.tag == "Fuel")
        {
            
        }*/
    }
}