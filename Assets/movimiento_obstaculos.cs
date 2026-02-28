using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimiento_obstaculos : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public Rigidbody2D rb; //se accede el componente de física (rigidbody)
    public float rapidez = 8f;   // ← velocidad a la que se mueve hacia el jugador

    void FixedUpdate()
    {
        // Mueve el objeto en el eje Z negativo (hacia el jugador)
        Vector2 velocidad = new Vector2(-rapidez, 0);

        // Se accede a la velocidad y se actualiza con el vector modificado
        rb.velocity = velocidad;
    }

    private void OnTriggerEnter(Collider other)
    {
        // Si llega al objeto "Destructor", se elimina solo
        if (other.name == "Destructor")
        {
            //Esta función destruye un GameObject
            Destroy(gameObject);
        }
    }
}
