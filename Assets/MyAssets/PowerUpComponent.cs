using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using UnityEngine;

public class PowerUpComponent : MonoBehaviour
{
    public float SizeFactor = 1.0f;
    public void GetSuperpowers(float duration)
    {
        StartCoroutine(ScaleUpAndDown(duration));
    }
    private IEnumerator ScaleUpAndDown(float duration)
    {
        transform.localScale = SizeFactor * Vector3.one;
        yield return new WaitForSeconds(duration);
        transform.localScale = Vector3.one;

    }
}
