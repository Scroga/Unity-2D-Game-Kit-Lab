using System.Collections;
using System.Collections.Generic;
using UnityEditor.Rendering;
using UnityEngine;
using UnityEngine.UIElements;

public class BulletController : MonoBehaviour
{
    public List<Bullet> Bullets;
    private float currentBulletForce;

    void Start()
    {
        Bullet bullet = Bullets[Random.Range(0, Bullets.Count)];

        GetComponent<Rigidbody2D>().velocity = transform.right * bullet.Speed;
        transform.localScale = bullet.Scale;
        GetComponent<SpriteRenderer>().color = bullet.Color;
        currentBulletForce = bullet.Force;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject);
    }

    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }

    public float GetBulletForce() 
    {
        return currentBulletForce; 
    }
}
