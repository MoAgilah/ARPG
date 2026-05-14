using UnityEngine;

public class PlayerCombat : MonoBehaviour
{
    public Transform attackPoint;
    public LayerMask enemyLayer;

    public Animator anim;

    public float cooldown = 2;
    private float timer;

    private void Update()
    {
        if (timer > 0)
            timer -= Time.deltaTime;
    }

    public void Attack()
    {
        if (timer <= 0)
        {
            anim.SetBool("isAttacking", true);

            timer = cooldown;
        }
    }

    public void DealDamage()
    {
        Collider2D[] enemies = Physics2D.OverlapCircleAll(attackPoint.position, StatsManager.instance.weaponRange, enemyLayer);

        foreach (Collider2D enemy in enemies)
        {
            if (enemy.isTrigger) continue;

            EnemyHealth enemyHealth = enemy.GetComponent<EnemyHealth>();
            if (enemyHealth != null)
            {
                enemyHealth.ChangeHealth(-StatsManager.instance.damage);

                EnemyKnockback enemyKnockback = enemy.GetComponent<EnemyKnockback>();
                if (enemyKnockback != null)
                {
                    enemyKnockback.Knockback(transform, StatsManager.instance.knockbackForce, StatsManager.instance.knockbackTime, StatsManager.instance.stunTime);
                }
            }
        }
    }

    public void FinishAttack()
    {
        anim.SetBool("isAttacking", false);
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(attackPoint.position, StatsManager.instance.weaponRange);
    }
}
