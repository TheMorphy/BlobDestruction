using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] Material enemyHit;
 
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.layer == 7)
        {
            if (collision.gameObject.GetComponent<FixedJoint>() != null)
            {
                collision.gameObject.GetComponent<FixedJoint>().breakForce = 0f;
                collision.gameObject.GetComponent<MeshRenderer>().material = enemyHit;
            }
        }
    }
}
