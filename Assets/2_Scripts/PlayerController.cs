using System.Collections;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float torqueForce = 3f;
    [SerializeField] float baseSpeed = 20f;
    [SerializeField] float boostSpeed = 30f;

    private Rigidbody2D rb2d;
    private SurfaceEffector2D surfaceEffector2D;
    private bool isBoosting = false;
    private bool isRuning = true;
        
    private enum InputKey
    {
        None, Left, Right
    }

    private InputKey currentKey = InputKey.None;

    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        surfaceEffector2D = Object.FindFirstObjectByType<SurfaceEffector2D>(); // Updated to use FindFirstObjectByType  
    }

    void Update()
    {
        currentKey = Input.GetKey(KeyCode.LeftArrow) ?
            InputKey.Left :
            Input.GetKey(KeyCode.RightArrow) ? InputKey.Right : InputKey.None;

        isBoosting = Input.GetKey(KeyCode.UpArrow);
    }

    public void GameOver()
    {
        isRuning = false;
    }

    void FixedUpdate()
    {
        if (!isRuning) return; 

        switch (currentKey)
        {
            case InputKey.Left:
                rb2d.AddTorque(torqueForce);
                break;
            case InputKey.Right:
                rb2d.AddTorque(-torqueForce);
                break;
            default:
                // Do nothing  
                break;
        }

        surfaceEffector2D.speed = isBoosting ? boostSpeed : baseSpeed;
    }
}
