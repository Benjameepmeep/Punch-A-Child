using System;
using System.Collections;
using UnityEngine;
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

    private PlayerInput.PlayerInput _playerInput;
    private GameObject _mainCamera;
    private Animator _playerAnim;
    private AnimationCurve _animationCurve;
    private Rigidbody2D _kidRigidbody2D;
    private LayerMask _layerGround;
    
    [SerializeField] private float punchForce;
    [SerializeField] private float angle;
    private Vector2 _currentVelocityVector;
    private float _timer;

    private bool _isFlying;
    private bool _hasLanded;

    private void Awake()
    {
        _playerAnim = GameObject.FindGameObjectWithTag("Player").GetComponent<Animator>();
        _playerInput = GetComponent<PlayerInput.PlayerInput>();
        _kidRigidbody2D = GetComponent<Rigidbody2D>();
        _mainCamera = GameObject.FindGameObjectWithTag("MainCamera");
    }

    private void Start()
    {
        _playerAnim.Play("PlayerIdle");
    }

    private void Update()
    {
        if (PlayerInput.PlayerInput.LockInBar)
        {
            var randomPunchForce = Random.Range(5, 50);
            var randomAngle = Random.Range(25, 65);
            StartCoroutine(ConvertToVelocityAndLaunch(randomPunchForce, randomAngle));
        }
        
        if (_hasLanded)
        {
            StartCoroutine(InitiateResetControlsAfterDelay());
            _isFlying = false;
            
            // Play animations, and leave kid lying in the dirt. + Count score / points.
            if (PlayerInput.PlayerInput.ResetLevel)
            {
                // TODO: Leave current kid laying in the dirt, reset all bools, and prepare camera and kids for new punch.
            }
        }
    }

    private void FixedUpdate()
    {
        if (!_isFlying) { return; }
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
        _isFlying = true;
        _playerInput.SwitchInputToKidFlying();
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (!CompareTag("Ground")) return;
        /*if (_kidRigidbody2D.velocity.x < 1f)
        {
            KidHasLanded(); 
        }*/
    }

    /*private bool KidHasLanded()
    {
        StartCoroutine(InitiateResetControlsAfterDelay());
        return _isFlying = false;
    }*/

    private IEnumerator InitiateResetControlsAfterDelay()
    {
        yield return new WaitForSeconds(2f);
        _playerInput.SwitchInputToLevelReset();
        yield break;
    }
    
}
