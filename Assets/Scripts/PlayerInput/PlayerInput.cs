using UnityEngine;

namespace PlayerInput
{
    public class PlayerInput : MonoBehaviour
    {
        private PlayerControls _controls;

        private void Awake() => _controls = new PlayerControls();

        private void OnEnable() => _controls.Enable();

        private void OnDisable() => _controls.Disable();

        public void SwitchInputToKidFlying()
        {
            _controls.Launch.Disable();
            _controls.KidFlying.Enable();
        }

        public void Switch()
        {
            
        }
        
        private bool _interact;
    
        private void Update()
        {
            _interact = _controls.KidFlying.UseItem.triggered;
        }
    }
}
