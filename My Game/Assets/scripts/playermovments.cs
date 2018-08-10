
using System.Collections.Generic;
using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class playermovments : MonoBehaviour
{

    // movments variables
    bool slide = false;
    [SerializeField]
    Collider2D PolyCollider;
    bool _pressed = false;
    public float speed;
    public float jump;
    float moveVelocity;
    bool grounded;
    bool touch;
    public LayerMask ground;
    [SerializeField]
    Collider2D groundCheck;
    Animator anim;

    private void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        // jump
        if (Input.GetKeyDown(KeyCode.UpArrow) && grounded)
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(
                GetComponent<Rigidbody2D>().velocity.x, jump);
        }

        grounded = groundCheck.IsTouchingLayers(ground);

        anim.SetBool("Grounded", grounded);
        if (Input.GetMouseButtonDown(0))
            _pressed = true;
        else if (Input.GetMouseButtonUp(0))
            _pressed = false;
    }
    public void Jump()
    {
        if (grounded)
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(
                GetComponent<Rigidbody2D>().velocity.x, jump);
        }

    }
  
}
