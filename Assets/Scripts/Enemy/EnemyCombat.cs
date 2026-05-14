using UnityEngine;

public class EnemyCombat : MonoBehaviour
{
    public int damage = 1;
    public Transform attackPoint;
    public float weaponRange;
    public float knockbackForce;
    public float stunTime;
    public LayerMask playerLayer;

    public void Attack()
    {
        Collider2D[] hits = Physics2D.OverlapCircleAll(attackPoint.position, weaponRange, playerLayer);
        if (hits.Length > 0)
        {
            if (hits[0].gameObject.tag == "Player")
            {
                hits[0].GetComponent<PlayerHealth>().ChangeHealth(-damage);
                hits[0].GetComponent<PlayerMovement>().Knockback(transform, knockbackForce, stunTime);
            }
        }
    }
}
