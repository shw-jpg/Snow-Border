using UnityEngine;

public class CeashDetector : MonoBehaviour
{
    void Start()
    {

    }

    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Ground"))
        {
            Debug.Log("��!,�� �Ӹ���!");
        }
    }
}
