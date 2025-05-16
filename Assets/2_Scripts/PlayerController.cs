using System.Collections;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float torqueForce = 3f;
    private Rigidbody2D rb2d;

    private enum InputKey
    {
        None, Left, Right
    }

    private InputKey currentKey = InputKey.None;

    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        currentKey = Input.GetKey(KeyCode.LeftArrow) ?
            InputKey.Left :
            Input.GetKey(KeyCode.RightArrow) ? InputKey.Right : InputKey.None;
    }

    void FixedUpdate()
    {
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
    }
}
