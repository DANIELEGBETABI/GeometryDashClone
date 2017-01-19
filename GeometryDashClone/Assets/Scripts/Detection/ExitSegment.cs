using UnityEngine;
using System.Collections;

public class ExitSegment : MonoBehaviour {

    public LayerMask EnterTrigger;
    public SegmentController segment;

    void OnEnable()
    {
        segment = GetComponentInParent<SegmentController>();
    }

    void OnTriggerExit2D(Collider2D collider)
    {
        if (LayerMask.GetMask(LayerMask.LayerToName(collider.gameObject.layer)) == EnterTrigger)
        {
            segment.ExitSegmentEnd();
        }
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        if (LayerMask.GetMask(LayerMask.LayerToName(collider.gameObject.layer)) == EnterTrigger)
        {
            segment.ExitSegmentBegin();
        }
    }
}
