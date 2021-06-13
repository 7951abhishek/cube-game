using UnityEngine;

public class Movement : MonoBehaviour
    //Change "Movement" 
{
    public float fwdForce = 500f;
    public float sideForce = 100f;
    public Rigidbody x;
    void Start()
    {
        x = GetComponent<Rigidbody>();
    }
    private void FixedUpdate() 
    {

        x.AddForce(0, 0, fwdForce*Time.deltaTime);
        if(Input.GetKey("a")||Input.GetKey(KeyCode.LeftArrow))
        {
            x.AddForce(-sideForce, 0,0);
        }
        if(Input.GetKey("d")||Input.GetKey(KeyCode.RightArrow))
        {
            x.AddForce(sideForce,0,0);
        }
    }
}