using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneradorPremios : MonoBehaviour
{
    public GameObject cuboPrefab;           // El Prefab del premio
    public Transform[] otrasPosiciones;     // Array de posibles posiciones de spawn

    private void Start()
    {
        // InvokeRepeating llama a "GenerarPremios" cada 3 segundos,
        // comenzando inmediatamente (0f de delay inicial).
        InvokeRepeating("GenerarPremios", 0f, 3f);
    }

    public void GenerarPremios()
    {
        // Elegir una posición aleatoria del array
        int randomIndex = Random.Range(0, otrasPosiciones.Length);
        // Crear el premio en esa posición sin rotación (Quaternion.identity)
        Instantiate(cuboPrefab, otrasPosiciones[randomIndex].position, Quaternion.identity);
    }
}