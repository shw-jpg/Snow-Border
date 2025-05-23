using UnityEngine;
using UnityEngine.SceneManagement; 

public class FinishLine : MonoBehaviour
{
    [Header("씬 전환 대기 시간(초)")]
    [SerializeField] private float reloaDelay = 2f;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Debug.Log("완주했습니다!");
            Invoke(nameof(LoadFirstScene), reloaDelay);
        }
    }

    private void LoadFirstScene()
    {
        SceneManager.LoadScene(0);
    }
}
