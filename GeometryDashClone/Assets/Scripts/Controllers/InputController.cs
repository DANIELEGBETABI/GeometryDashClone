using UnityEngine;
using System.Collections;
using System;
public class InputController : MonoBehaviour {

    public event Action OnJump;
    public ICommand jumpCommand = new JumpCommand();
   	void Update () {
        ICommand command = HandleInput();
        if (command!=null)
        {
            command.Execute();
        }
	}

    ICommand HandleInput()
    {
        if (Input.GetKey(KeyCode.W))
        {
            return jumpCommand;
        }
        return null;
    }

    public void AddJumpObserver(Action function)
    {
        jumpCommand.AddObserver(function);
    }

    public void RemoveJumpObserver(Action function)
    {
        jumpCommand.RemoveObserver(function);
    }
}
