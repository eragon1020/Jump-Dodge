using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject obstaclePrefab;
    private Vector3 spawnPos = new Vector3(25, 0, 0);
    private float startDelay = 2f;
    private float repeatRate = 2f;
    
    // Añadimos la referencia al jugador para revisar el GameOver
    private PlayerController playerControllerScript;

    void Start()
    {
        // Busca al jugador en la escena al iniciar
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
        
        InvokeRepeating("SpawnObstacle", startDelay, repeatRate);
    }

    void SpawnObstacle()
    {
        // SOLO si el juego NO ha terminado, genera un nuevo obstáculo
        if (playerControllerScript.gameOver == false)
        {
            Instantiate(obstaclePrefab, spawnPos, obstaclePrefab.transform.rotation);
        }
    }
}