using UnityEngine;
using UnityEngine.SceneManagement; 

public class FinishLine : MonoBehaviour
{
    [Header("�� ��ȯ ��� �ð�(��)")]
    [SerializeField] private float reloaDelay = 2f;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Debug.Log("�����߽��ϴ�!");
            Invoke(nameof(LoadFirstScene), reloaDelay);
        }
    }

    private void LoadFirstScene()
    {
        SceneManager.LoadScene(0);
    }
}
