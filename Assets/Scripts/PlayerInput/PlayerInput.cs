using System;
using System.Collections;
using UnityEngine;
using UnityEngine.Rendering.Universal.Internal;

namespace PlayerInput
{
    public class PlayerInput : MonoBehaviour
    {
        private PlayerControls _controls;

        private void Awake() => _controls = new PlayerControls();

        private void OnEnable() => _controls.Enable();

        private void OnDisable() => _controls.Disable();

        private void Start()
        {
            SwitchInputToLaunch();
        }

        public void SwitchInputToKidFlying()
        {
            _controls.Launch.Disable();
            _controls.KidFlying.Enable();
        }

        public void SwitchInputToLaunch()
        {
            _controls.Launch.Enable();
            _controls.KidFlying.Disable();
        }

        public void SwitchInputToLevelReset()
        {
            _controls.Launch.Disable();
            _controls.KidFlying.Disable();
            ResetLevel = true;
        }
        
        // Player Launch Controls:
        public static bool LockInBar = false;
        
        // KidFlying Controls:
        public static bool UseItem;
        public static bool FastForward;
        
        // ResetLevel Controls:
        public static bool ResetLevel = false;
        public static readonly bool LevelHasBeenReset = false;
    
        private void Update()
        {
            LockInBar = _controls.Launch.LockIn.triggered;
            for (int i = 0; i < 2; i++)
            {
                if (LockInBar)
                {
                    i++;
                }
            }
            
            UseItem = _controls.KidFlying.UseItem.triggered;
            FastForward = _controls.KidFlying.FastForward.triggered;
            
            ResetLevel = _controls.ResetStage.ResetButton.triggered;
            
            if (LockInBar)
            {
                StartCoroutine(LockBarMeters());
            }
        }

        private IEnumerator LockBarMeters()
        {
            SwitchInputToKidFlying();
            yield return new WaitUntil(() => LevelHasBeenReset);
            SwitchInputToLaunch();
        }
        
    }
}
