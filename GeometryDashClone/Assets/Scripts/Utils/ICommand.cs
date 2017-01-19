using UnityEngine;
using System.Collections;
using System;

public interface ICommand  {
     void Execute();
     void AddObserver(Action function);
     void RemoveObserver(Action function);
}
