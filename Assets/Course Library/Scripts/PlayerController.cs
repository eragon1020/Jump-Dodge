using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    private Rigidbody playerRb;
    private Animator playerAnim;
    private AudioSource playerAudio;         // Paso 6

    public InputAction jumpAction;
    public float jumpForce = 10f;
    public float gravityModifier = 1.5f;
    public bool isOnGround = true;
    public bool gameOver = false;

    public ParticleSystem explosionParticle; // Paso 2
    public ParticleSystem dirtParticle;      // Paso 3

    public AudioClip jumpSound;              // Paso 5
    public AudioClip crashSound;             // Paso 5

    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
        playerAnim = GetComponent<Animator>();
        playerAudio = GetComponent<AudioSource>(); // Paso 6
        jumpAction.Enable();
        Physics.gravity *= gravityModifier;
    }

    void Update()
    {
        if (jumpAction.triggered && isOnGround && !gameOver)
        {
            playerRb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            isOnGround = false;
            playerAnim.SetTrigger("Jump_trig");
            dirtParticle.Stop();                          // Paso 3: detener polvo al saltar
            playerAudio.PlayOneShot(jumpSound, 1.0f);    // Paso 6: sonido de salto
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isOnGround = true;
            dirtParticle.Play();   // Paso 3: reanudar polvo al aterrizar
        }
        else if (collision.gameObject.CompareTag("Obstacle"))
        {
            gameOver = true;
            Debug.Log("Game Over!");
            playerAnim.SetBool("Death_b", true);
            playerAnim.SetInteger("DeathType_int", 1);
            explosionParticle.Play();                      // Paso 2: explosión al chocar
            dirtParticle.Stop();                           // Paso 3: detener polvo al chocar
            playerAudio.PlayOneShot(crashSound, 1.0f);    // Paso 6: sonido de choque
        }
    }
}