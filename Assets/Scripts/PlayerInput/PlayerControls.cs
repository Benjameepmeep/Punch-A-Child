//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.7.0
//     from Assets/Scripts/PlayerInput/PlayerControls.inputactions
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public partial class @PlayerControls: IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerControls"",
    ""maps"": [
        {
            ""name"": ""Launch"",
            ""id"": ""dffc9193-a1bb-4b7b-8d89-f48e5e531e9d"",
            ""actions"": [
                {
                    ""name"": ""Lock-In"",
                    ""type"": ""Button"",
                    ""id"": ""3d10c1ad-4805-46b7-a809-751ef4ac8298"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""c96f418f-75e6-4a8a-a191-55e032a8c2ea"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Lock-In"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1c7ef787-0ffc-4f98-87db-8be43990f496"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Lock-In"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""KidFlying"",
            ""id"": ""4754c791-75ef-4d3b-ad74-a556af906b91"",
            ""actions"": [
                {
                    ""name"": ""Use Item"",
                    ""type"": ""Button"",
                    ""id"": ""00c4ca28-0224-4bf3-8623-04ee168462f0"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Fast-Forward"",
                    ""type"": ""Button"",
                    ""id"": ""a69f7b08-70bc-4d60-a89d-2980ab1461f8"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""361e8dc3-e672-47cb-add9-fc7c913979fa"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Use Item"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""510bd2a4-b1fb-47a8-b2ec-6ecb41351f4d"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Fast-Forward"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c8bc95b5-900c-48a4-aceb-6c6068db5d28"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Use Item"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""ResetStage"",
            ""id"": ""1ad9202d-ec63-4c42-8728-4e474dfa5eb9"",
            ""actions"": [
                {
                    ""name"": ""ResetButton"",
                    ""type"": ""Button"",
                    ""id"": ""05f8bfe7-2e85-4b5b-80ee-6e53f310d0a1"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""f4addf31-78d0-41b7-91a3-c35693d8e8e3"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ResetButton"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0c43cf52-5229-44bf-b2de-25bf2d3ab749"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ResetButton"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Launch
        m_Launch = asset.FindActionMap("Launch", throwIfNotFound: true);
        m_Launch_LockIn = m_Launch.FindAction("Lock-In", throwIfNotFound: true);
        // KidFlying
        m_KidFlying = asset.FindActionMap("KidFlying", throwIfNotFound: true);
        m_KidFlying_UseItem = m_KidFlying.FindAction("Use Item", throwIfNotFound: true);
        m_KidFlying_FastForward = m_KidFlying.FindAction("Fast-Forward", throwIfNotFound: true);
        // ResetStage
        m_ResetStage = asset.FindActionMap("ResetStage", throwIfNotFound: true);
        m_ResetStage_ResetButton = m_ResetStage.FindAction("ResetButton", throwIfNotFound: true);
    }

    public void Dispose()
    {
        UnityEngine.Object.Destroy(asset);
    }

    public InputBinding? bindingMask
    {
        get => asset.bindingMask;
        set => asset.bindingMask = value;
    }

    public ReadOnlyArray<InputDevice>? devices
    {
        get => asset.devices;
        set => asset.devices = value;
    }

    public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

    public bool Contains(InputAction action)
    {
        return asset.Contains(action);
    }

    public IEnumerator<InputAction> GetEnumerator()
    {
        return asset.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Enable()
    {
        asset.Enable();
    }

    public void Disable()
    {
        asset.Disable();
    }

    public IEnumerable<InputBinding> bindings => asset.bindings;

    public InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false)
    {
        return asset.FindAction(actionNameOrId, throwIfNotFound);
    }

    public int FindBinding(InputBinding bindingMask, out InputAction action)
    {
        return asset.FindBinding(bindingMask, out action);
    }

    // Launch
    private readonly InputActionMap m_Launch;
    private List<ILaunchActions> m_LaunchActionsCallbackInterfaces = new List<ILaunchActions>();
    private readonly InputAction m_Launch_LockIn;
    public struct LaunchActions
    {
        private @PlayerControls m_Wrapper;
        public LaunchActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @LockIn => m_Wrapper.m_Launch_LockIn;
        public InputActionMap Get() { return m_Wrapper.m_Launch; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(LaunchActions set) { return set.Get(); }
        public void AddCallbacks(ILaunchActions instance)
        {
            if (instance == null || m_Wrapper.m_LaunchActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_LaunchActionsCallbackInterfaces.Add(instance);
            @LockIn.started += instance.OnLockIn;
            @LockIn.performed += instance.OnLockIn;
            @LockIn.canceled += instance.OnLockIn;
        }

        private void UnregisterCallbacks(ILaunchActions instance)
        {
            @LockIn.started -= instance.OnLockIn;
            @LockIn.performed -= instance.OnLockIn;
            @LockIn.canceled -= instance.OnLockIn;
        }

        public void RemoveCallbacks(ILaunchActions instance)
        {
            if (m_Wrapper.m_LaunchActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(ILaunchActions instance)
        {
            foreach (var item in m_Wrapper.m_LaunchActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_LaunchActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public LaunchActions @Launch => new LaunchActions(this);

    // KidFlying
    private readonly InputActionMap m_KidFlying;
    private List<IKidFlyingActions> m_KidFlyingActionsCallbackInterfaces = new List<IKidFlyingActions>();
    private readonly InputAction m_KidFlying_UseItem;
    private readonly InputAction m_KidFlying_FastForward;
    public struct KidFlyingActions
    {
        private @PlayerControls m_Wrapper;
        public KidFlyingActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @UseItem => m_Wrapper.m_KidFlying_UseItem;
        public InputAction @FastForward => m_Wrapper.m_KidFlying_FastForward;
        public InputActionMap Get() { return m_Wrapper.m_KidFlying; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(KidFlyingActions set) { return set.Get(); }
        public void AddCallbacks(IKidFlyingActions instance)
        {
            if (instance == null || m_Wrapper.m_KidFlyingActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_KidFlyingActionsCallbackInterfaces.Add(instance);
            @UseItem.started += instance.OnUseItem;
            @UseItem.performed += instance.OnUseItem;
            @UseItem.canceled += instance.OnUseItem;
            @FastForward.started += instance.OnFastForward;
            @FastForward.performed += instance.OnFastForward;
            @FastForward.canceled += instance.OnFastForward;
        }

        private void UnregisterCallbacks(IKidFlyingActions instance)
        {
            @UseItem.started -= instance.OnUseItem;
            @UseItem.performed -= instance.OnUseItem;
            @UseItem.canceled -= instance.OnUseItem;
            @FastForward.started -= instance.OnFastForward;
            @FastForward.performed -= instance.OnFastForward;
            @FastForward.canceled -= instance.OnFastForward;
        }

        public void RemoveCallbacks(IKidFlyingActions instance)
        {
            if (m_Wrapper.m_KidFlyingActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IKidFlyingActions instance)
        {
            foreach (var item in m_Wrapper.m_KidFlyingActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_KidFlyingActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public KidFlyingActions @KidFlying => new KidFlyingActions(this);

    // ResetStage
    private readonly InputActionMap m_ResetStage;
    private List<IResetStageActions> m_ResetStageActionsCallbackInterfaces = new List<IResetStageActions>();
    private readonly InputAction m_ResetStage_ResetButton;
    public struct ResetStageActions
    {
        private @PlayerControls m_Wrapper;
        public ResetStageActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @ResetButton => m_Wrapper.m_ResetStage_ResetButton;
        public InputActionMap Get() { return m_Wrapper.m_ResetStage; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(ResetStageActions set) { return set.Get(); }
        public void AddCallbacks(IResetStageActions instance)
        {
            if (instance == null || m_Wrapper.m_ResetStageActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_ResetStageActionsCallbackInterfaces.Add(instance);
            @ResetButton.started += instance.OnResetButton;
            @ResetButton.performed += instance.OnResetButton;
            @ResetButton.canceled += instance.OnResetButton;
        }

        private void UnregisterCallbacks(IResetStageActions instance)
        {
            @ResetButton.started -= instance.OnResetButton;
            @ResetButton.performed -= instance.OnResetButton;
            @ResetButton.canceled -= instance.OnResetButton;
        }

        public void RemoveCallbacks(IResetStageActions instance)
        {
            if (m_Wrapper.m_ResetStageActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IResetStageActions instance)
        {
            foreach (var item in m_Wrapper.m_ResetStageActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_ResetStageActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public ResetStageActions @ResetStage => new ResetStageActions(this);
    public interface ILaunchActions
    {
        void OnLockIn(InputAction.CallbackContext context);
    }
    public interface IKidFlyingActions
    {
        void OnUseItem(InputAction.CallbackContext context);
        void OnFastForward(InputAction.CallbackContext context);
    }
    public interface IResetStageActions
    {
        void OnResetButton(InputAction.CallbackContext context);
    }
}
