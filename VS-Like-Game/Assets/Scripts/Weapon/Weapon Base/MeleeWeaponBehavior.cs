using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeleeWeaponBehavior : MonoBehaviour
{
    /// <summary>
    ///Base script of all melee weapons!
    /// </summary>
    public float destoryAfterSeconds;
    protected virtual void Start()
    {
        Destroy(gameObject, destoryAfterSeconds);
    }
}
