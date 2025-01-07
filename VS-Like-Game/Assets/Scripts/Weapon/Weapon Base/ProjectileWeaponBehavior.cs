using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Base script of all projectile behaviors [To be placed on a prefab of a weapon that is a projectile]
/// </summary>
public class ProjectileWeaponBehavior : MonoBehaviour
{

    protected Vector3 direction;
    public float destroyAfterSeconds;
    // Start is called before the first frame update
    protected virtual void Start()
    {
        Destroy(gameObject, destroyAfterSeconds);
    }

    public void DirectionChecker(Vector3 dir)
    {
        direction = dir;

        float dirx = direction.x;
        float diry = direction.y;

        Vector3 scale = transform.localScale;
        Vector3 rotation = transform.rotation.eulerAngles;

        if(dirx < 0 && diry == 0) ///left
        {
            rotation.z = rotation.z + 180;
        }
        else if (dirx == 0 && diry < 0) ///down
        {
            rotation.z = rotation.z - 90f;
        }
        else if (dirx == 0 && diry > 0) ///up
        {
            rotation.z = rotation.z + 90f;           
        }
        else if (dirx > 0 && diry > 0) ///upRight
        {
            rotation.z = rotation.z + 45f;
        }
        else if (dirx > 0 && diry < 0) ///upDown
        {
            rotation.z = rotation.z + -45f;
        }
        else if (dirx < 0 && diry < 0) ///leftDown
        {
            rotation.z = rotation.z + -135f;
        }
        else if (dirx < 0 && diry > 0) ///leftUp
        {
            rotation.z = rotation.z + 135f;
        }

        transform.localScale = scale;
        transform.rotation = Quaternion.Euler(rotation);
    }
}
