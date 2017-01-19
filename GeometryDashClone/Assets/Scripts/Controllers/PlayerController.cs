using UnityEngine;
using System.Collections;
using System;
public class PlayerController : MonoBehaviour {

    public Rigidbody2D rigidbody;
    [Range(0,20)]
    public float Velocity;
    [Range(0, 2000)]
    public float JumpForce;
    public LayerMask ground;
    public event Action OnPlayerDeath;
    private bool _isOnGround = true;
    public bool isOnGround
    {
        get
        {
            return _isOnGround;
        }
        set
        {
            if (!value && _isOnGround)
            {
                Rotate();
            }
            _isOnGround = value;
        }
    }
	void Start () {
        rigidbody = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        rigidbody.velocity = Velocity * Vector2.right + rigidbody.velocity.y * Vector2.up;
	}

    public void Jump()
    {
        if (isOnGround)
        {   
            isOnGround = false;
            rigidbody.velocity = new Vector2(rigidbody.velocity.x, 0.0f);// set velocity.y = 0 for
            rigidbody.AddForce(JumpForce * Vector2.up);
            Rotate();
        }
    }

    public void PlayerDeath()
    {
        print("Player Death");
        if (OnPlayerDeath!=null)
        {
            OnPlayerDeath();
        }
    }

    public void Rotate()
    {
        
    
    }

}
