using UnityEngine;

public class CollisionScript : MonoBehaviour
{
    public Movement mmt;
    public Rigidbody playerRigid;
    void start()
    {
        playerRigid = GetComponent<Rigidbody>();
        mmt = FindObjectOfType<Movement>();
    }
    private void OnCollisionEnter(Collision other)
    {
        if(other.collider.tag == "Obstacle")
        {
            mmt.enabled = false;
            FindObjectOfType<Gamemanager>().Restart();
           //playerRigid.constraints = RigidbodyConstraints.FreezeAll;
        }
        if(other.collider.tag == "nextLevel")
        {
            mmt.enabled = false;
            FindObjectOfType<Gamemanager>().NextLevel();
        }
    }
}
