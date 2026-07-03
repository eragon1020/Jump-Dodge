using UnityEngine;

public class RepeatBackground : MonoBehaviour
{
    private Vector3 startPos;
    private float repeatWidth;

    void Start()
    {
        // Guarda la posición inicial del fondo
        startPos = transform.position;
        
        // Obtiene la mitad del ancho del fondo usando su BoxCollider
        repeatWidth = GetComponent<BoxCollider>().size.x / 2;
    }

    void Update()
    {
        // Si el fondo se movió hacia la izquierda más allá de su mitad, lo resetea
        if (transform.position.x < startPos.x - repeatWidth)
        {
            transform.position = startPos;
        }
    }
}