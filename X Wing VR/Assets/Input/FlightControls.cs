//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.11.2
//     from Assets/Input/FlightControls.inputactions
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

public partial class @FlightControls: IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @FlightControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""FlightControls"",
    ""maps"": [
        {
            ""name"": ""Flying"",
            ""id"": ""b79a814c-4806-4606-a854-49ce7782d8bc"",
            ""actions"": [
                {
                    ""name"": ""Pitch+Yaw"",
                    ""type"": ""Value"",
                    ""id"": ""5ace26a9-f7f4-4370-8861-5627f2148b15"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Thurst+Roll"",
                    ""type"": ""Value"",
                    ""id"": ""ef0a4361-d7ed-4e61-ac52-9a382b29d07c"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Shoot"",
                    ""type"": ""Button"",
                    ""id"": ""a8af60cd-2bb7-4974-b2cd-2dbf79e84f18"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": ""Hold"",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""435f5eed-2f36-4916-993d-fd234bf3822d"",
                    ""path"": ""<XRController>{RightHand}/joystick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Pitch+Yaw"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""93865235-4e1d-41e8-acd9-4848433cd909"",
                    ""path"": ""<Gamepad>/rightStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Pitch+Yaw"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f0378ba8-5489-4ac4-903b-f48632709fba"",
                    ""path"": ""<XRController>{LeftHand}/joystick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Thurst+Roll"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""32f3fd42-869d-4972-8cc2-5a0b3c8c1f94"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Thurst+Roll"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3cf26499-52ef-495a-8566-7492e56f583f"",
                    ""path"": ""<XRController>{RightHand}/{TriggerButton}"",
                    ""interactions"": ""Hold"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Shoot"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5a16e086-a933-4ddd-849d-b712f182a18e"",
                    ""path"": ""<Gamepad>/rightTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Shoot"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""aa7fc5e5-5ee7-4525-9b13-7187b3882fbf"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": ""Hold"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Shoot"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Flying
        m_Flying = asset.FindActionMap("Flying", throwIfNotFound: true);
        m_Flying_PitchYaw = m_Flying.FindAction("Pitch+Yaw", throwIfNotFound: true);
        m_Flying_ThurstRoll = m_Flying.FindAction("Thurst+Roll", throwIfNotFound: true);
        m_Flying_Shoot = m_Flying.FindAction("Shoot", throwIfNotFound: true);
    }

    ~@FlightControls()
    {
        UnityEngine.Debug.Assert(!m_Flying.enabled, "This will cause a leak and performance issues, FlightControls.Flying.Disable() has not been called.");
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

    // Flying
    private readonly InputActionMap m_Flying;
    private List<IFlyingActions> m_FlyingActionsCallbackInterfaces = new List<IFlyingActions>();
    private readonly InputAction m_Flying_PitchYaw;
    private readonly InputAction m_Flying_ThurstRoll;
    private readonly InputAction m_Flying_Shoot;
    public struct FlyingActions
    {
        private @FlightControls m_Wrapper;
        public FlyingActions(@FlightControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @PitchYaw => m_Wrapper.m_Flying_PitchYaw;
        public InputAction @ThurstRoll => m_Wrapper.m_Flying_ThurstRoll;
        public InputAction @Shoot => m_Wrapper.m_Flying_Shoot;
        public InputActionMap Get() { return m_Wrapper.m_Flying; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(FlyingActions set) { return set.Get(); }
        public void AddCallbacks(IFlyingActions instance)
        {
            if (instance == null || m_Wrapper.m_FlyingActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_FlyingActionsCallbackInterfaces.Add(instance);
            @PitchYaw.started += instance.OnPitchYaw;
            @PitchYaw.performed += instance.OnPitchYaw;
            @PitchYaw.canceled += instance.OnPitchYaw;
            @ThurstRoll.started += instance.OnThurstRoll;
            @ThurstRoll.performed += instance.OnThurstRoll;
            @ThurstRoll.canceled += instance.OnThurstRoll;
            @Shoot.started += instance.OnShoot;
            @Shoot.performed += instance.OnShoot;
            @Shoot.canceled += instance.OnShoot;
        }

        private void UnregisterCallbacks(IFlyingActions instance)
        {
            @PitchYaw.started -= instance.OnPitchYaw;
            @PitchYaw.performed -= instance.OnPitchYaw;
            @PitchYaw.canceled -= instance.OnPitchYaw;
            @ThurstRoll.started -= instance.OnThurstRoll;
            @ThurstRoll.performed -= instance.OnThurstRoll;
            @ThurstRoll.canceled -= instance.OnThurstRoll;
            @Shoot.started -= instance.OnShoot;
            @Shoot.performed -= instance.OnShoot;
            @Shoot.canceled -= instance.OnShoot;
        }

        public void RemoveCallbacks(IFlyingActions instance)
        {
            if (m_Wrapper.m_FlyingActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IFlyingActions instance)
        {
            foreach (var item in m_Wrapper.m_FlyingActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_FlyingActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public FlyingActions @Flying => new FlyingActions(this);
    public interface IFlyingActions
    {
        void OnPitchYaw(InputAction.CallbackContext context);
        void OnThurstRoll(InputAction.CallbackContext context);
        void OnShoot(InputAction.CallbackContext context);
    }
}
