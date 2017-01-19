using UnityEngine;
using System.Collections;
using System;

public class JumpCommand : ICommand {

    public event Action OnJump;
    public void Execute()
    {
        if (OnJump!=null)
        {
            OnJump();    
        }
    }
    public void AddObserver(Action function)
    {
        OnJump += function;
    }
    public void RemoveObserver(Action function)
    {
        OnJump -= function;
    }
}
