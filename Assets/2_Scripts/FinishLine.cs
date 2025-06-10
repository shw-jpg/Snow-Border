using UnityEngine;
using UnityEngine.SceneManagement; 

public class FinishLine : MonoBehaviour
{
    [SerializeField] private float delayBeforeLoading = 2f;
    [SerializeField] private ParticleSystem finishEffect;

    private AudioSource audioSource;
    private bool isFinished = false;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player") && !isFinished)
        {
            isFinished = true;

            finishEffect.Play();
            audioSource.Play();
            Invoke(nameof(LoadFirstScene), delayBeforeLoading);
        }
    }

    private void LoadFirstScene()
    {
        SceneManager.LoadScene(0);
    }
}
