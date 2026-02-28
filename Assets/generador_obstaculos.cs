using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class generador_obstaculos : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public class GenerarCubos : MonoBehaviour
{
    public GameObject cuboPrefab;
    public Transform posicionGeneradora;
    public Transform[] otrasPosiciones;

    private void OnTriggerEnter(Collider other)
    {
        // Solo genera si el Jugador chocó con el objeto dueño de este script
        if (other.gameObject.name == "Jugador")
        {
            int randomIndex = Random.Range(0, otrasPosiciones.Length);
            Instantiate(cuboPrefab, posicionGeneradora.position, Quaternion.identity);
            Instantiate(cuboPrefab, otrasPosiciones[randomIndex].position, Quaternion.identity);
        }
    }
}
}
