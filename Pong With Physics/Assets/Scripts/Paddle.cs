using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    // get reference to the rigidbody
    protected Rigidbody2D _rigidbody;
    public float speed = 10f;

    private void Awake() {
        _rigidbody = GetComponent<Rigidbody2D>();
    }
}
