using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Gamekit2D;

public class ShootingController : MonoBehaviour
{
    [SerializeField]
    public GameObject Bullet;
    [SerializeField]
    public GameObject BulletSpawner;

    void Start() { }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.H))
        {
            float facing = GetComponent<PlayerCharacter>().GetFacing();
            Vector3 bulletPosition;
            Quaternion bulletRotation;
            bool flipSprite = false;

            if (facing > 0)
            {
                bulletPosition = transform.Find("FacingRightBulletSpawnPoint").position;
                bulletRotation = Quaternion.Euler(0, 0, 0);
            }
            else 
            {
                bulletPosition = transform.Find("FacingLeftBulletSpawnPoint").position;
                bulletRotation = Quaternion.Euler(0, 0, 180);
                flipSprite = true;
            }
            GameObject bulletInstance = Instantiate(Bullet, bulletPosition, bulletRotation, BulletSpawner.GetComponent<Transform>());
            SpriteRenderer bulletSprite = bulletInstance.GetComponent<SpriteRenderer>();
            bulletSprite.flipY = flipSprite;
        }
    }
}
