using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnifeController : WeaponController
{
    // Start is called before the first frame update
    protected override void Start()
    {
        base.Start();
    }

    protected override void Attack()
    {
        base.Attack();
        GameObject spawnedKnife = Instantiate(prefab);
        spawnedKnife.transform.position = transform.position; /// Spawn position (on player)
        spawnedKnife.GetComponent<KnifeBehavior>().DirectionChecker(pm.lastMovedVector); ///Reference and set the direction
    }
}
