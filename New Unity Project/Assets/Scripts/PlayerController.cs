using System.Collections;
using UnityEngine;
using UnityEditor;

public class PlayerController : MonoBehaviour
{
    [Tooltip("its very responsive now so try not to go to fast")]
    public float PlayerSpeed;
    public Rigidbody2D PlayerRigidbody;
    public Animator animator;
    private Vector3 Direction;
    [Tooltip("its usefull for cutseens")]
    public bool NotWalking;
     void Start()
    {


    }

  

    void FixedUpdate()
    {
        if(NotWalking == false)
        {
            Direction = Vector2.zero;
            Direction.x = Input.GetAxisRaw("Horizontal");
            Direction.y = transform.position.y;
            if (Direction != Vector3.zero)
            {
                PlayerRigidbody.MovePosition(transform.position + Direction * PlayerSpeed * Time.deltaTime);
                animator.SetFloat("Horizontal", Direction.x);
 
            }

        }


    }

}
