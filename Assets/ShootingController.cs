using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Gamekit2D;

public class ShootingController : MonoBehaviour
{
    [SerializeField]
    public GameObject Bullet;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.H))
        {
            float facing = GetComponent<PlayerCharacter>().GetFacing();

            Vector3 bulletPosition = (facing > 0) ? transform.Find("FacingRightBulletSpawnPoint").position : transform.Find("FacingLeftBulletSpawnPoint").position;
            Quaternion bulletRotation = (facing > 0) ? Quaternion.Euler(0, 0, 0) : Quaternion.Euler(0, 0, 180);

            GameObject bulletInstance = Instantiate(Bullet, bulletPosition, bulletRotation);

        }
    }
}
