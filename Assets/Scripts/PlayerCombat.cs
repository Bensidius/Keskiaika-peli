using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCombat : MonoBehaviour
{

    // public bool attack;

    public Animator animator;

    public Transform attackPoint;
    public LayerMask enemyLayers;
    public float attackRange = 0.5f;

    //public int attackDamage = 40;

    //public CircleCollider2D col;

   
    void Start()
    {
        //col = GetComponent<CircleCollider2D>();
    }


    // Update is called once per frame
    void Update()
    {
     // if(Input.GetKeyDown(KeyCode.C))
     // {
     //     Attack();
     // }  
    }

    //void Attack()
    //{

     //   attack = true;

        // Play an attack animation
       // animator.SetTrigger("Attack");
        
       // col.radius = 0.80f;

       // col.radius = 0.1f;

        //col.enabled = false;
        //attack = false;

        // detect enemies in range of attack
        //Collider2D[] hitEnemies = Physics2D.OverlapCircleAll(attackPoint.position, attackRange, enemyLayers);
        // damage them
        //foreach(Collider2D enemy in hitEnemies)
       // {
            //enemy.GetComponent<Enemy>().TakeDamage(attackDamage); 
            //Debug.Log("Isketään" + enemy.name);
       // }
   // }


//void OnDrawGizmosSelected()
//{
//    if(attackPoint == null)
 //       return;
 //   Gizmos.DrawWireSphere(attackPoint.position, attackRange);
//}

}
