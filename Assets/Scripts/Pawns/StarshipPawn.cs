using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarshipPawn : Pawn
{
    private Mover mover;
    public override void Move(Vector2 input)
    {
       mover.Move(input);
    }

    public override void moverelative(Vector2 input, bool useturbo)
    {
        mover.moverelative(input,useturbo);
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public override void Start()
    {
        mover = GetComponent<Mover>();
    }

    public override void teleport()
    {
        mover.teleport();
    }

    // Update is called once per frame
    public override void Update()
    {
        
    }

   
  
}



