using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class DestructManager : MonoBehaviour
{
    public ColumnForceManager columnParts;

    private void OnCollisionEnter2D(Collision2D collision)
    {

        BulletController bullet = collision.gameObject.GetComponent<BulletController>();
        if (bullet != null) 
        {
            gameObject.SetActive(false);
            columnParts.Break(bullet.GetBulletForce());
        }
    }
}
