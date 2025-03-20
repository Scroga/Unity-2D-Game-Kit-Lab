using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PowerUpItemController : MonoBehaviour
{
    public UnityEvent itemEffect;
    public float itemDuration;

    private CapsuleCollider2D trigger;
    private SpriteRenderer spriteRenderer;


    public void OnTriggerEnter2D(Collider2D collision) 
    {
        if (collision.gameObject.tag == "Player")
        {
            itemEffect.Invoke();
            trigger = GetComponent<CapsuleCollider2D>();
            spriteRenderer = GetComponent<SpriteRenderer>();
            StartCoroutine(SetDisable());
        }
    }

    private IEnumerator SetDisable()
    {
        trigger.enabled = false;
        spriteRenderer.color = new Color(spriteRenderer.color.r, spriteRenderer.color.g, spriteRenderer.color.b, 0.3f);
        yield return new WaitForSeconds(itemDuration);
        trigger.enabled = true;
        StartCoroutine(Flicker());
        spriteRenderer.color = new Color(spriteRenderer.color.r, spriteRenderer.color.g, spriteRenderer.color.b, 1.0f);
    }
    private IEnumerator Flicker()
    {
        for (int i = 0; i < 3; ++i)
        {
            spriteRenderer.color = Color.cyan;
            yield return new WaitForSeconds(0.1f);
            spriteRenderer.color = Color.white;
            yield return new WaitForSeconds(0.1f);
        }
    }

}
