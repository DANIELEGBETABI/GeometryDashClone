using UnityEngine;
using System.Collections;
using System;
public class SegmentController : MonoBehaviour {

    public event Action<SegmentController>  OnExitSegmentEnd;
    public event Action                     OnExitSegmentBegin;

    public bool IsFinal                     = false;
    public bool IsFirst                     = false;
    
    public void ExitSegmentBegin()
    {
        if ((OnExitSegmentBegin != null) && (!IsFinal))
        {
            OnExitSegmentBegin();
        }
    }

    public void ExitSegmentEnd()
    {
        if ((OnExitSegmentEnd != null) && (!IsFinal))
        {
            OnExitSegmentEnd(this);
        }
    }
}
