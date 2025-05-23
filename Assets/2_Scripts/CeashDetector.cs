using UnityEngine;
using UnityEngine.SceneManagement;

public class CeashDetector : MonoBehaviour
{
    [SerializeField] private float reloadDelay = 2f;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Ground"))
        {
            Debug.Log("��!,�� �Ӹ���!");
            Invoke(nameof(LoadFirstScene), reloadDelay);
        }
    }

    private void LoadFirstScene()
    {
        SceneManager.LoadScene(0);
    }
}
