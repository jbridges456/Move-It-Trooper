using UnityEngine;
using UnityEngine.UIElements;

public class shipmover : Mover
{
    public KeyCode keypress;

    public float xMin;
    public float xMax;
    public float yMin;
    public float yMax;
    public float speed;
    private Rigidbody pawn;
    public float turbospeed;

    public override void Move(Vector2 input)
    {
        Vector3 Movement = input * speed; 
        pawn.MovePosition(pawn.position+Movement);

   
    }

    public override void moverelative(Vector2 input,bool useturbo)
    {
        Vector3 Movement = input * Time.deltaTime;
        if (useturbo)
        {
            Movement = Movement * turbospeed;
        }
        else {
            Movement = Movement * speed;
        }
        Movement = pawn.rotation * Movement;
        pawn.MovePosition(pawn.position + Movement);

    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public override void Start()
    {
       pawn = GetComponent<Rigidbody>();
    }

    public override void teleport()
    {
        // Change the position to some random x and y location

        Vector3 posititon = new Vector3(Random.Range(xMin, xMax), Random.Range(yMin, yMax), 0);
        transform.SetPositionAndRotation(posititon, Quaternion.identity);
    }

    // Update is called once per frame
    public override void Update()
    {
    
        
    }
}
