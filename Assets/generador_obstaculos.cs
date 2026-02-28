using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class generador_obstaculos : MonoBehaviour
{
    public GameObject TrianglePrefab;
    public Transform posicionGeneradora;
    public Transform[] otrasPosiciones;
    public float spawnInterval = 1f;

    private bool isSpawning = false;
    private Coroutine spawnRoutine;

    // Usar física 2D: OnTriggerEnter2D
    private void OnTriggerEnter2D(Collider2D other)
    {
        // Genera indefinidamente cuando el jugador entra en el trigger.
        // Acepta tag "Player" o nombres comunes para compatibilidad.
        if (other.CompareTag("Player") || other.gameObject.name == "Jugador" || other.gameObject.name == "player")
        {
            if (!isSpawning)
            {
                isSpawning = true;
                spawnRoutine = StartCoroutine(SpawnContinuously());
            }
        }
    }

    private IEnumerator SpawnContinuously()
    {
        while (true)
        {
            if (TrianglePrefab != null)
            {
                if (otrasPosiciones == null || otrasPosiciones.Length == 0)
                {
                    Instantiate(TrianglePrefab, posicionGeneradora.position, Quaternion.identity);
                }
                else
                {
                    int randomIndex = Random.Range(0, otrasPosiciones.Length);
                    Instantiate(TrianglePrefab, posicionGeneradora.position, Quaternion.identity);
                    Instantiate(TrianglePrefab, otrasPosiciones[randomIndex].position, Quaternion.identity);
                }
            }

            yield return new WaitForSeconds(spawnInterval);
        }
    }

    private void OnDisable()
    {
        if (spawnRoutine != null)
        {
            StopCoroutine(spawnRoutine);
            spawnRoutine = null;
        }
        isSpawning = false;
    }
}
