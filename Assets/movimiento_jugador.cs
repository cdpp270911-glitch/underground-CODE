using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimiento_jugador : MonoBehaviour
{   bool enSuelo; 
    public Rigidbody2D rb;
    // Start is called before the first frame update312321
    void Start()
    {   

    }

    // Update is called once per frame
    void Update()
    {
        Saltar(); 
    }
    private void Saltar()
    {
        if (Input.GetButtonDown("Jump") && enSuelo ) 
        {
            rb.AddForce(Vector2.up * 10, ForceMode2D.Impulse);
            
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name.Equals("piso"))
        {
            Debug.Log("toco el piso");
            enSuelo = true;
        }
        
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.name.Equals("piso"))
        {
            Debug.Log("toco el piso");
            enSuelo = false;
        }
}
}