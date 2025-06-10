using UnityEngine;
using UnityEngine.SceneManagement;

public class CeashDetector : MonoBehaviour
{
    [SerializeField] private float reloadDelay = 2f;
    [SerializeField] private ParticleSystem crashEffect;
    [SerializeField] private AudioClip crashsound;
    
    private AudioSource audioSource;
    private PlayerController playerController;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
        playerController = GetComponent<PlayerController>();
    }


    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Ground"))
        {
            crashEffect.Play();
            audioSource.PlayOneShot(crashsound);
            playerController.GameOver();
            Invoke(nameof(LoadFirstScene), reloadDelay);
        }
    }

    private void LoadFirstScene()
    {
        SceneManager.LoadScene(0);
    }
}
