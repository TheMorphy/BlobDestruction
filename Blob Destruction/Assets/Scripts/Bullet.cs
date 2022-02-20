using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] Material enemyHit;
 
    // When the bullet collides with an enemy you change the material of the ball that's been hit and disable Fixed Joint
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
