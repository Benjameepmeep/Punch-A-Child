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

    #region Initialization

    private GameObject _mainCamera;
    private Rigidbody2D _kidRigidbody2D;
    private LayerMask _layerGround;
    
    private float _punchForce;
    private float _bounceMagnitudeThreshold;
    private Vector2 _currentVelocityVector;

    private bool _isFlying;

    private void Awake()
    {
        _kidRigidbody2D = GetComponent<Rigidbody2D>();
        _mainCamera = GameObject.FindGameObjectWithTag("MainCamera");
    }

    #endregion

    #region Trajectory

    private void FixedUpdate()
    {
        if (!_isFlying) { return; }
        
        // TODO: add current velocityVector along with its magnitude.

        switch (_currentVelocityVector.y)
        {
            case >= -1:
                // Play upwards animation
                throw new NotImplementedException();
            case < -1:
                // Play downwards animation
                throw new NotImplementedException();
        }
    }

    private IEnumerator ConvertToVelocityAndLaunch(float punchForce, float launchAngle)
    {
        /* var kidTransform = transform;
        var kidDirection = kidTransform.forward;
        var elevationAxis = kidTransform.right;
         var releaseVector = Quaternion.AngleAxis(launchAngle, elevationAxis) * kidDirection;
                _kidRigidbody2D.velocity = releaseVector * punchForce;*/
        
        float velx = punchForce * Mathf.Cos(launchAngle * Mathf.Deg2Rad);
        float vely = punchForce * Mathf.Sin(launchAngle * Mathf.Deg2Rad);
        
        // Figure out set delay for punch to execute.
        yield return new WaitForSeconds(2);
        
        _kidRigidbody2D.velocity = new Vector2(velx, vely);
    }

    private void BounceTrajectory(Vector2 velocity)
    {
        
    }

    #endregion

    #region Collision

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (!CompareTag("Ground")) return;
        if (_currentVelocityVector.magnitude > _bounceMagnitudeThreshold)
        {
            _isFlying = false;
            BounceTrajectory(_currentVelocityVector);
            // Set new launchPos and initialize new launch.
        }
        else
        {
            // Land the kid, and stop movement with respective animations.
        }
    }

    #endregion
    
}
