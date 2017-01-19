using UnityEngine;
using System.Collections;

public class TrapDetection : MonoBehaviour {
    public LayerMask trap;
    public PlayerController player;
    void OnTriggerEnter2D(Collider2D collider)
    {
        if (LayerMask.GetMask(LayerMask.LayerToName(collider.gameObject.layer)) == trap)
        {
            player.PlayerDeath();
        }
    }
}
