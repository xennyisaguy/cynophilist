using System.Collections;
using UnityEngine;
using UnityEditor;

public class PlayerController : MonoBehaviour
{
    [Header("walking")]
    [Tooltip("its very responsive now so try not to go to fast")]
    public float PlayerSpeed;
    [Tooltip("its usefull for cutseens")]
    public bool Notwalking;
    [Space]
    [Header("components")]
    public Rigidbody2D PlayerRigidbody;
    public Animator animator;
    private Vector3 Direction;
    [Space]
    [Header("sound Efeacts")]
    public AudioClip WalkingSound;
    public AudioClip breathingSound;
    public AudioSource sound;
    void Start()
    {
 
    }

  

    void FixedUpdate()
    {
        if(Notwalking == false)
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
    public void walkingSounds()
    {
        if (!sound.isPlaying) sound.PlayOneShot(WalkingSound, 1.0F);
    }
    public void BreathingSounds()
    {
        if(!sound.isPlaying) sound.PlayOneShot(breathingSound, 1.0F);

   }

}
