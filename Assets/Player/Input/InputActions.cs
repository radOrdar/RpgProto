//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.2.0
//     from Assets/Player/Input/New Controls.inputactions
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

public partial class @InputActions : IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @InputActions()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""New Controls"",
    ""maps"": [
        {
            ""name"": ""KeyboardMouse"",
            ""id"": ""188bc439-956a-4683-8691-1450d0cfa6f8"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""fc8c9f4f-6c89-41f6-8798-fee402e92cc6"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Aim"",
                    ""type"": ""PassThrough"",
                    ""id"": ""69106bfc-ad95-4225-bdf7-942bfd66c6bd"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Shoot"",
                    ""type"": ""Button"",
                    ""id"": ""a9f84098-d19a-4b14-8237-1f2255504971"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""OnKey1"",
                    ""type"": ""Button"",
                    ""id"": ""4d5e09f6-14e2-4015-8e33-99265e56b234"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""OnKey2"",
                    ""type"": ""Button"",
                    ""id"": ""dd3c23a3-8f23-4057-b9d6-5a8e7a960f9d"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""OnMouseScroll"",
                    ""type"": ""Value"",
                    ""id"": ""b25b29f5-6692-4f59-a00e-5b3fa29f23b2"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""WASD"",
                    ""id"": ""29d7a619-bd69-472e-8b5f-699ccdbb1dd7"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""75f10d5c-3c3c-4d76-b184-d3d1f173d8b7"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""872480a0-0bf0-4125-bd0c-9e7e82d058ef"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""52c18f41-6703-4299-9e50-1bda0e526bcb"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""af8776e7-77c4-4135-9242-98bc29782a31"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Arrows"",
                    ""id"": ""4c271db5-1dfd-4ffd-b382-854e49a42e1a"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""2c757ac3-ee0c-4a4b-af71-0613efc0a88a"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""033df903-6d63-4031-8992-293485e5a9d8"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""beb5b5cd-aabe-4818-8e85-eebb16b5b421"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""f5fbfd24-dcde-4b96-8d94-91cc7a2c83f1"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""b147541a-135d-4fe8-ad85-2dc9678d716d"",
                    ""path"": ""<Mouse>/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Aim"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""62989d67-ef26-43fc-bc04-ebbed5d09edc"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Shoot"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1a60a1a1-42fc-4616-8de3-859008e8d24d"",
                    ""path"": ""<Keyboard>/1"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""OnKey1"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3e74495a-85d1-4bc4-a628-4b4c9ad1d971"",
                    ""path"": ""<Keyboard>/2"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""OnKey2"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""60eb95d2-ae9f-4bff-8b68-fdd6e90d7e94"",
                    ""path"": ""<Mouse>/scroll"",
                    ""interactions"": """",
                    ""processors"": ""NormalizeVector2"",
                    ""groups"": """",
                    ""action"": ""OnMouseScroll"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // KeyboardMouse
        m_KeyboardMouse = asset.FindActionMap("KeyboardMouse", throwIfNotFound: true);
        m_KeyboardMouse_Move = m_KeyboardMouse.FindAction("Move", throwIfNotFound: true);
        m_KeyboardMouse_Aim = m_KeyboardMouse.FindAction("Aim", throwIfNotFound: true);
        m_KeyboardMouse_Shoot = m_KeyboardMouse.FindAction("Shoot", throwIfNotFound: true);
        m_KeyboardMouse_OnKey1 = m_KeyboardMouse.FindAction("OnKey1", throwIfNotFound: true);
        m_KeyboardMouse_OnKey2 = m_KeyboardMouse.FindAction("OnKey2", throwIfNotFound: true);
        m_KeyboardMouse_OnMouseScroll = m_KeyboardMouse.FindAction("OnMouseScroll", throwIfNotFound: true);
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

    // KeyboardMouse
    private readonly InputActionMap m_KeyboardMouse;
    private IKeyboardMouseActions m_KeyboardMouseActionsCallbackInterface;
    private readonly InputAction m_KeyboardMouse_Move;
    private readonly InputAction m_KeyboardMouse_Aim;
    private readonly InputAction m_KeyboardMouse_Shoot;
    private readonly InputAction m_KeyboardMouse_OnKey1;
    private readonly InputAction m_KeyboardMouse_OnKey2;
    private readonly InputAction m_KeyboardMouse_OnMouseScroll;
    public struct KeyboardMouseActions
    {
        private @InputActions m_Wrapper;
        public KeyboardMouseActions(@InputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_KeyboardMouse_Move;
        public InputAction @Aim => m_Wrapper.m_KeyboardMouse_Aim;
        public InputAction @Shoot => m_Wrapper.m_KeyboardMouse_Shoot;
        public InputAction @OnKey1 => m_Wrapper.m_KeyboardMouse_OnKey1;
        public InputAction @OnKey2 => m_Wrapper.m_KeyboardMouse_OnKey2;
        public InputAction @OnMouseScroll => m_Wrapper.m_KeyboardMouse_OnMouseScroll;
        public InputActionMap Get() { return m_Wrapper.m_KeyboardMouse; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(KeyboardMouseActions set) { return set.Get(); }
        public void SetCallbacks(IKeyboardMouseActions instance)
        {
            if (m_Wrapper.m_KeyboardMouseActionsCallbackInterface != null)
            {
                @Move.started -= m_Wrapper.m_KeyboardMouseActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_KeyboardMouseActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_KeyboardMouseActionsCallbackInterface.OnMove;
                @Aim.started -= m_Wrapper.m_KeyboardMouseActionsCallbackInterface.OnAim;
                @Aim.performed -= m_Wrapper.m_KeyboardMouseActionsCallbackInterface.OnAim;
                @Aim.canceled -= m_Wrapper.m_KeyboardMouseActionsCallbackInterface.OnAim;
                @Shoot.started -= m_Wrapper.m_KeyboardMouseActionsCallbackInterface.OnShoot;
                @Shoot.performed -= m_Wrapper.m_KeyboardMouseActionsCallbackInterface.OnShoot;
                @Shoot.canceled -= m_Wrapper.m_KeyboardMouseActionsCallbackInterface.OnShoot;
                @OnKey1.started -= m_Wrapper.m_KeyboardMouseActionsCallbackInterface.OnOnKey1;
                @OnKey1.performed -= m_Wrapper.m_KeyboardMouseActionsCallbackInterface.OnOnKey1;
                @OnKey1.canceled -= m_Wrapper.m_KeyboardMouseActionsCallbackInterface.OnOnKey1;
                @OnKey2.started -= m_Wrapper.m_KeyboardMouseActionsCallbackInterface.OnOnKey2;
                @OnKey2.performed -= m_Wrapper.m_KeyboardMouseActionsCallbackInterface.OnOnKey2;
                @OnKey2.canceled -= m_Wrapper.m_KeyboardMouseActionsCallbackInterface.OnOnKey2;
                @OnMouseScroll.started -= m_Wrapper.m_KeyboardMouseActionsCallbackInterface.OnOnMouseScroll;
                @OnMouseScroll.performed -= m_Wrapper.m_KeyboardMouseActionsCallbackInterface.OnOnMouseScroll;
                @OnMouseScroll.canceled -= m_Wrapper.m_KeyboardMouseActionsCallbackInterface.OnOnMouseScroll;
            }
            m_Wrapper.m_KeyboardMouseActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
                @Aim.started += instance.OnAim;
                @Aim.performed += instance.OnAim;
                @Aim.canceled += instance.OnAim;
                @Shoot.started += instance.OnShoot;
                @Shoot.performed += instance.OnShoot;
                @Shoot.canceled += instance.OnShoot;
                @OnKey1.started += instance.OnOnKey1;
                @OnKey1.performed += instance.OnOnKey1;
                @OnKey1.canceled += instance.OnOnKey1;
                @OnKey2.started += instance.OnOnKey2;
                @OnKey2.performed += instance.OnOnKey2;
                @OnKey2.canceled += instance.OnOnKey2;
                @OnMouseScroll.started += instance.OnOnMouseScroll;
                @OnMouseScroll.performed += instance.OnOnMouseScroll;
                @OnMouseScroll.canceled += instance.OnOnMouseScroll;
            }
        }
    }
    public KeyboardMouseActions @KeyboardMouse => new KeyboardMouseActions(this);
    public interface IKeyboardMouseActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnAim(InputAction.CallbackContext context);
        void OnShoot(InputAction.CallbackContext context);
        void OnOnKey1(InputAction.CallbackContext context);
        void OnOnKey2(InputAction.CallbackContext context);
        void OnOnMouseScroll(InputAction.CallbackContext context);
    }
}
