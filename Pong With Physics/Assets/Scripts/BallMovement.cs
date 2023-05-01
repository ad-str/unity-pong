using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    private Vector2 _direction;
    public float speed = 100f;

    private Rigidbody2D _rb;

    private void Awake() {
        _rb = GetComponent<Rigidbody2D>();    
    }

    private void Start() {
        AddStartingForce();
    }

    private void AddStartingForce() {
        // choose a random angle
        float randAngle = Random.Range(Mathf.PI / 12, Mathf.PI / 4);

        // get x and y
        float x = Random.value < 0.5f ? -Mathf.Cos(randAngle) : Mathf.Cos(randAngle);
        float y = Random.value < 0.5f ? -Mathf.Sin(randAngle) : Mathf.Sin(randAngle);

        _rb.AddForce(new Vector2(x, y) * speed);
    }
}
