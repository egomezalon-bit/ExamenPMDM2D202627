using System.Numerics;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class PlayerController : MonoBehaviour
{

    bool isGrounded = true;
    public float speed;
    public float jumpForce; 
    public CheckGround checkGround;
    

    public Transform playerPosition;
    private SpriteRenderer _spriteRenderer;
    private Rigidbody2D _rigidBody;
    private Animator _animator;
    // Start is called before the first frame update
    void Start()
    {
        

    }

    // Update is called once per frame
    void Update()
    {
        checkMove();
        checkJump();
    }

    void FixedUpdate()
    {
        
    }

    private void checkMove()
    {
        if (Input.GetKeyDown(KeyCode.A)){
            
        }
        if (Input.GetKeyDown(KeyCode.D)){
            
        }
    }    
    
    private void checkJump()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            
        }
    }

    public void impulse(float impulse)
    {
        /*
        Este método se ejecutará cuando el jugador salte sobre 
        la cabeza del enemigo impulsado al jugador hacia arriba.
        */

    }



}
