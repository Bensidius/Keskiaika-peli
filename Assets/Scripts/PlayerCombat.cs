using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCombat : MonoBehaviour
{

    public Animator animator;

    public Transform attackPoint;
    public LayerMask enemyLayers;
    public float attackRange = 0.5f;

   



    // Update is called once per frame
    void Update()
    {
      if(Input.GetKeyDown(KeyCode.C))
      {
          Attack();
      }  
    }

    void Attack()
    {
        // Play an attack animation
        animator.SetTrigger("Attack");
        // detect enemies in range of attack
        Collider2D[] hitEnemies = Physics2D.OverlapCircleAll(attackPoint.position, attackRange, enemyLayers);
        // damage them
        foreach(Collider2D enemy in hitEnemies)
        {
            enemy.GetComponent<Enemy>().TakeDamage(40); 
            //Debug.Log("Isketään" + enemy.name);
        }
    }


void OnDrawGizmosSelected()
{
    if(attackPoint == null)
        return;
    Gizmos.DrawWireSphere(attackPoint.position, attackRange);
}

}
