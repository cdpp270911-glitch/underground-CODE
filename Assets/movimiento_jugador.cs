using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimiento_jugador : MonoBehaviour
{   bool choquetubo; 
    float speed = 20f;
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
        if (Input.GetButtonDown("Jump") && (choquetubo == false)) 
        {
            rb.AddForce(Vector2.up*speed, ForceMode2D.Impulse);
            
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        string nombreColisionador = collision.gameObject.name;

        if (nombreColisionador.Equals("limite") || nombreColisionador.Equals("limite2") || nombreColisionador.Equals("tubo"))
        {
            Debug.Log("toco el piso");
            choquetubo = true;
        }
        
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
         string nombreColisionador = collision.gameObject.name;
        if (nombreColisionador.Equals("limite")|| nombreColisionador.Equals("limite2") || nombreColisionador.Equals("obstaculo"))
        {
            Debug.Log("toco el piso");
            choquetubo = false;
        }
}
    public class MovimientoObjeto : MonoBehaviour
{

}
}