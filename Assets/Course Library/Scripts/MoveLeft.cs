using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    public float speed = 30f;
    private PlayerController playerControllerScript;
    private float leftBound = -15f; // Límite en X donde el objeto desaparece

    void Start()
    {
        // Busca al jugador para saber si el juego sigue activo
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    void Update()
    {
        // Si el juego no ha terminado, se mueve a la izquierda
        if (playerControllerScript.gameOver == false)
        {
            transform.Translate(Vector3.left * speed * Time.deltaTime);
        }

        // NUEVO: Si el objeto pasa el límite izquierdo y es un obstáculo, se destruye
        if (transform.position.x < leftBound && gameObject.CompareTag("Obstacle"))
        {
            Destroy(gameObject);
        }
    }
}