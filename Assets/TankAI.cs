using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankAI : MonoBehaviour
{
    public float attackRange = 5;
    public float moveSpeed = 3;
    public float beforeFireDelay = 0.3f;
    public float afterFireDelay = 1f;

    IEnumerator Start()
    {
        EnemyTurret turret = GetComponentInChildren<EnemyTurret>();
        var tankTr = Tank.instance.transform;
        var tr = transform;
        while (true)
        {
            // 공격 사정거리까지 이동.
            while (Vector3.Distance(tr.position, tankTr.position) > attackRange)
            {
                var direction = tankTr.position - tr.position;
                direction.Normalize();
                transform.Translate(moveSpeed * Time.deltaTime * direction, Space.World);
                transform.forward = direction;
                yield return null;
            }

            // 공격
            yield return new WaitForSeconds(beforeFireDelay);
            turret.Fire();
            yield return new WaitForSeconds(afterFireDelay);
        }
    }
    private void OnDrawGizmos()
    {
        Gizmos.DrawWireSphere(transform.position, attackRange);
    }
}
