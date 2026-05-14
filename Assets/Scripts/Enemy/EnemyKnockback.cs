using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyKnockback : MonoBehaviour
{
    private Rigidbody2D rb;
    private EnemyMovement em;

    public void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        em = GetComponent<EnemyMovement>();
    }

    public void Knockback(Transform forceTransform, float force, float knockbackTime, float stunTime)
    {
        em.ChangeState(EnemyState.Knockback);
        StartCoroutine(KnockbackCounter(knockbackTime, stunTime));

        Vector2 direction = (transform.position - forceTransform.position).normalized;
        rb.linearVelocity = direction * force;
    }

    IEnumerator KnockbackCounter(float knockbackTime, float stunTime)
    {
        yield return new WaitForSeconds(knockbackTime);
        rb.linearVelocity = Vector2.zero;
        yield return new WaitForSeconds(stunTime);
        em.ChangeState(EnemyState.Idle);
    }
}
