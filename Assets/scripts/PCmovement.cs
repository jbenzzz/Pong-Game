using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PCmovement : MonoBehaviour {

    public float pcdifficulty = 10;
    public ball ballreference;
    private Rigidbody2D batpc;

    private void Awake()
    {
        batpc = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        Vector2 newposition = Vector2.Lerp(transform.position, new Vector2(transform.position.x, ballreference.transform.position.y), pcdifficulty*Time.deltaTime);
        batpc.MovePosition(newposition);
    }


}
