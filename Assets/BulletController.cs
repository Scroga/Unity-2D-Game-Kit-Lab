using System.Collections;
using System.Collections.Generic;
using UnityEditor.Rendering;
using UnityEngine;
using UnityEngine.UIElements;

public class BulletController : MonoBehaviour
{
    [SerializeField]
    public float Speed = 1.0f;


    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = Vector2.right * Speed;
    }

    void Update()
    {
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Destroy bullet");
        Destroy(gameObject);
    }

    private void OnBecameInvisible()
    {
        Debug.Log("Destroy bullet");
        Destroy(gameObject);
    }
}
