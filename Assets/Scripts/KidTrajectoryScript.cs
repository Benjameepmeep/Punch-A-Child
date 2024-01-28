using System;
using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using Random = UnityEngine.Random;
using Vector2 = UnityEngine.Vector2;

public class KidTrajectoryScript : MonoBehaviour
{
    // TODO: Receive collision from meter gauges (%-based), with force and angle received.
        // TODO: If weapon is equipped, apply extra force.
    // TODO: Launch kid based on those parameters.
        // TODO: Zoom-in before punch, and then zoom out as kid is launched.
    // TODO: Add threshold for bouncing, and why/how kid continues to bounce. (Material adjustments?)
        // TODO: Live checks for angle and force on the frame of the kid.
    // TODO: Count traveled distance from startPos.
    // TODO: Add SFX and VFX to kid during different stages of launch (Idle, currently punched, flying, bouncing, landing).

    private SceneManager _sceneManager;
    private PlayerInput.PlayerInput _playerInput;
    private Animator _playerAnim;
    private Animator _kidAnim;
    private AnimationCurve _animationCurve;
    private Rigidbody2D _kidRigidbody2D;
    private LayerMask _layerGround;
    
    [SerializeField] private float punchForce;
    [SerializeField] private float angle;
    private Vector2 _currentVelocityVector;
    private float _timer;

    private bool _isFlying;
    private bool _facingForwardOnGround;
    private bool _kidHasLanded;
    private bool _nextLevelCanBeLoaded = false;

    private void Awake()
    {
        _sceneManager = GameObject.FindGameObjectWithTag("SceneManager").GetComponent<SceneManager>();
        _playerAnim = GameObject.FindGameObjectWithTag("Player").GetComponent<Animator>();
        _kidAnim = GetComponent<Animator>();
        _playerInput = GetComponent<PlayerInput.PlayerInput>();
        _kidRigidbody2D = GetComponent<Rigidbody2D>();
    }

    private void Start()
    {
        _playerAnim.Play("PlayerIdle");
        _kidAnim.Play("PettyPete");
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            _sceneManager.Loadlevel();
        }
        if (PlayerInput.PlayerInput.LockInBar)
        {
            var randomPunchForce = Random.Range(5, 50);
            var randomAngle = Random.Range(25, 65);
            StartCoroutine(ConvertToVelocityAndLaunch(randomPunchForce, randomAngle));
        }
        
        if (_kidHasLanded)
        {
            _isFlying = false;
        }
    }

    private void FixedUpdate()
    {
        if (!_isFlying) { return; }

        if (_kidRigidbody2D.velocityY > 0 || _kidRigidbody2D.velocityY < 0)
        {
            _kidAnim.Play("PettyPeteFlying");
        }
    }
    
    private IEnumerator ConvertToVelocityAndLaunch(float punch, float launchAngle)
    { 
        Debug.Log("PreparingLaunch");
        _playerAnim.Play("PlayerPunchAnim");
        /*var kidTransform = transform;
        var kidDirection = kidTransform.forward;
        var elevationAxis = kidTransform.right;
        var releaseVector = Quaternion.AngleAxis(launchAngle, elevationAxis) * kidDirection;*/
        
        float velocityX = punch * Mathf.Cos(launchAngle * Mathf.Deg2Rad);
        float velocityY = punch * Mathf.Sin(launchAngle * Mathf.Deg2Rad);
        
        // Figure out set delay for punch to execute.
        yield return new WaitForSeconds(1.4f);
        Debug.Log("Launching");
        // _kidRigidbody2D.velocity = releaseVector * punchForce;
        
        _kidRigidbody2D.velocity = new Vector2(velocityX, velocityY);
        Debug.Log("Kid Velocity: " + _kidRigidbody2D.velocity);
        _kidRigidbody2D.AddForce(_kidRigidbody2D.velocity, ForceMode2D.Force);
        
        _kidAnim.Play("PettyPeteFlying");
        _isFlying = true;
        // _playerInput.SwitchInputToKidFlying();
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (!CompareTag("Ground")) return;

        if (_facingForwardOnGround)
        { 
            _kidAnim.Play("PettyPeteGroundedForward");
            _facingForwardOnGround = false;
        }
        else
        {
            _kidAnim.Play("PettyPeteGroundBackward");
            _facingForwardOnGround = true;
        }
        
        
        if (_kidRigidbody2D.velocity.x < 0.1f)
        {
            _nextLevelCanBeLoaded = true;
        }
    }

    private IEnumerator InitiateResetControlsAfterDelay()
    {
        yield return new WaitForSeconds(2f);
        // _playerInput.SwitchInputToLevelReset();
        yield break;
    }
    
}
