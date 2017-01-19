using UnityEngine;
using System.Collections;

public class CrashDetection : MonoBehaviour {

    public LayerMask ground;
    public PlayerController player;
    void OnTriggerEnter2D(Collider2D collider)
    {
        if (LayerMask.GetMask(LayerMask.LayerToName(collider.gameObject.layer)) == ground)
        {
            print(collider.gameObject.name);
            player.PlayerDeath();
        }
    }
}
