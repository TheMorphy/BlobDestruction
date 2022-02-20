using UnityEngine;

public class JointCheck : MonoBehaviour
{
    // This collision is checking whether there's a fixed joint on the connected bodies or not to prevent any bugs
    // Basically, you don't want to be connected to the ball that's already been hit
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.layer == 6) // If collided with the bullet
        {
            if (GetComponent<FixedJoint>() != null) // Checking if there is still Fixed Joint component
            {
                if (GetComponent<FixedJoint>().connectedBody.GetComponent<FixedJoint>() == null) // If you've hit the connected ball - disconnect from him
                {
                    GetComponent<FixedJoint>().breakForce = 0f; // Disconnect
                }
            }
        }
    }
}
