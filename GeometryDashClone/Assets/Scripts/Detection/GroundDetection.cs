using UnityEngine;
using System.Collections;

public class GroundDetection : MonoBehaviour {

    public PlayerController player;
    public LayerMask ground;
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (LayerMask.GetMask(LayerMask.LayerToName(collision.gameObject.layer)) == ground)
        {
            player.isOnGround = true;
        }
    }

    void OnCollisionExit2D(Collision2D collision)
    {
        if (LayerMask.GetMask(LayerMask.LayerToName(collision.gameObject.layer)) == ground)
        {
            player.isOnGround = false;
        }
    }

    void OnCollisionStay2D(Collision2D collision)
    {
        if (LayerMask.GetMask(LayerMask.LayerToName(collision.gameObject.layer)) == ground)
        {
            player.isOnGround = true;
        }
    }
}
