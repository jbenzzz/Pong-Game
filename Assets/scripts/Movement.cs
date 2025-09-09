using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {

    public float speed = 15f;
    public string axis;

    private void FixedUpdate()
    {
        float input = Input.GetAxisRaw(axis);
        GetComponent<Rigidbody2D>().velocity = new Vector2(0, input) * speed;
    }
}
