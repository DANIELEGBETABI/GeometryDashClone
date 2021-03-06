﻿using UnityEngine;
using System.Collections;

public class EnterSegment : MonoBehaviour {

    public LayerMask EnterTrigger;
    public SegmentController segment;

    void OnEnable()
    {
        segment = GetComponentInParent<SegmentController>();
    }
    void OnTriggerEnter2D(Collider2D collider)
    {

        if (LayerMask.GetMask(LayerMask.LayerToName(collider.gameObject.layer)) == EnterTrigger)
        {
            //segment.EnterSegmentBegin();
        }
    }

    void OnTriggerExit2D(Collider2D collider)
    {
        if (LayerMask.GetMask(LayerMask.LayerToName(collider.gameObject.layer)) == EnterTrigger)
        {
            //segment.EnterSegmentEnd();
        }
    }
}
