using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Gamekit2D;

public class ShootingController : MonoBehaviour
{
    public BulletController BulletController;
    public GameObject BulletSpawner;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.H))
        {
            float facing = GetComponent<PlayerCharacter>().GetFacing();
            Vector3 bulletPosition;
            Quaternion bulletRotation;

            if (facing > 0)
            {
                bulletPosition = transform.Find("FacingRightBulletSpawnPoint").position;
                bulletRotation = Quaternion.Euler(0, 0, 0);
            }
            else 
            {
                bulletPosition = transform.Find("FacingLeftBulletSpawnPoint").position;
                bulletRotation = Quaternion.Euler(0, 0, 180);
            }
            BulletController bulletInstance = Instantiate(BulletController, bulletPosition, bulletRotation, BulletSpawner.GetComponent<Transform>());
            SpriteRenderer bulletSprite = bulletInstance.GetComponent<SpriteRenderer>();
        }
    }
}
