using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Pawn : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
   public virtual void Start()
    {
        
    }

    // Update is called once per frame
    public virtual void Update()
    {
        
    }

    public abstract void Move(Vector2 input);

    public abstract void moverelative(Vector2 input, bool useturbo);
    public abstract void teleport(); 



}
