using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fireworks : MonoBehaviour
{

    [SerializeField] GameObject particleExplosion;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        var explosionVFX = Instantiate(particleExplosion, gameObject.transform.position, Quaternion.identity) as GameObject;
        Destroy(explosionVFX, 1f);
        Destroy(gameObject);
    }

}
