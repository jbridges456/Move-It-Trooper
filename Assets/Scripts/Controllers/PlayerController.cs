using UnityEngine;

public class PlayerController : Controller
{
    public KeyCode moveForward;
    public KeyCode moveBackward;
    public KeyCode rotateClockwise;
    public KeyCode rotateCounterclockwise;
    public KeyCode teleport;
    public KeyCode up;
    public KeyCode down;
    public KeyCode left;
    public KeyCode right;
    public KeyCode leftshift;
    public KeyCode rightshift;





    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public override void Start()
    {

    }

    // Update is called once per frame
    public override void Update()
    {
     MakeDecisions ();
 
    }
    public void MakeDecisions()
    {
        bool useturbo = Input.GetKey(leftshift) || Input.GetKey(rightshift);
        if (Input.GetKey(moveForward))
        {
            pawn.moverelative(Vector2.up, useturbo);
           
        }

        if (Input.GetKey(moveBackward))
        {
            pawn.moverelative(-Vector2.up, useturbo);
            
        }

        if (Input.GetKey(rotateClockwise))
        {
            pawn.moverelative(Vector2.left, useturbo);
          
        }

        if (Input.GetKey(rotateCounterclockwise))
        {
            pawn.moverelative(Vector2.right, useturbo);
            
        }
        if (Input.GetKeyDown(up))
        {
            pawn.Move(Vector2.up);

        }

        if (Input.GetKeyDown(down))
        {
            pawn.Move(Vector2.down);

        }

        if (Input.GetKeyDown(right))
        {
            pawn.Move(Vector2.right);

        }

        if (Input.GetKeyDown(left))
        {
            pawn.Move(Vector2.left);

        }
            if (Input.GetKeyDown(teleport))
        {
            pawn.teleport();
        }
    }
}