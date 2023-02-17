using UnityEngine;

public class Move : MonoBehaviour
{
    private float _speed = 0.5f;

    private Rigidbody2D _rigidbody;

    private void Awake()
    {
        _rigidbody = gameObject.GetComponent<Rigidbody2D>();
    }
    private void Update()
    {
        var horizontalInput = Input.GetAxisRaw("Horizontal");
        _rigidbody.AddForce(new Vector2(horizontalInput * _speed, 0));
    }
}
