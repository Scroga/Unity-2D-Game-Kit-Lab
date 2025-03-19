using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColumnForceManager : MonoBehaviour
{
    public void Break(float force)
    {
        this.gameObject.SetActive(true);
        foreach (Transform child in transform)
        {
            Rigidbody2D rigidbody = child.gameObject.GetComponent<Rigidbody2D>();
            if (rigidbody != null)
                rigidbody.AddForce(force * Random.insideUnitCircle, ForceMode2D.Impulse);

        }
    }
}
