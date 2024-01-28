using System;
using System.Collections;
using UnityEngine;
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

    private GameObject _mainCamera;
    private Rigidbody2D _kidRigidbody2D;
    private LayerMask _layerGround;
    
    [SerializeField] private float punchForce;
    [SerializeField] private float angle;
    private Vector2 _currentVelocityVector;

    private bool _isFlying;
    private bool _hasLanded;

    private void Awake()
    {
        _kidRigidbody2D = GetComponent<Rigidbody2D>();
        _mainCamera = GameObject.FindGameObjectWithTag("MainCamera");
    }
    
    private void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            StartCoroutine(ConvertToVelocityAndLaunch(punchForce, angle));
        }

        if (KidHasLanded())
        {
            // Play animations, and leave kid lying in the dirt. + Count score / points.
        }
    }

    private void FixedUpdate()
    {
        if (!_isFlying) { return; }

        switch (_currentVelocityVector.y)
        {
            case >= -0.1f:
                // Play upwards animation
                throw new NotImplementedException();
            case < -1:
                // Play downwards animation
                throw new NotImplementedException();
        }
    }

    public IEnumerator ConvertToVelocityAndLaunch(float punch, float launchAngle)
    { 
        /* var kidTransform = transform;
        var kidDirection = kidTransform.forward;
        var elevationAxis = kidTransform.right;
        var releaseVector = Quaternion.AngleAxis(launchAngle, elevationAxis) * kidDirection;
        _kidRigidbody2D.velocity = releaseVector * punchForce;*/
        
        float velocityX = punchForce * Mathf.Cos(launchAngle * Mathf.Deg2Rad);
        float velocityY = punchForce * Mathf.Sin(launchAngle * Mathf.Deg2Rad);
        
        // Figure out set delay for punch to execute.
        yield return new WaitForSeconds(2);
        
        _kidRigidbody2D.velocity = new Vector2(velocityX, velocityY);
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (!CompareTag("Ground")) return;
        if (_kidRigidbody2D.velocity.x < 1f)
        {
            _kidRigidbody2D.velocity = Vector2.zero;
            KidHasLanded(); 
        }
    }

    private bool KidHasLanded()
    {
        _kidRigidbody2D.velocity = Vector2.zero;
        return _isFlying = false;
    }
  
}
