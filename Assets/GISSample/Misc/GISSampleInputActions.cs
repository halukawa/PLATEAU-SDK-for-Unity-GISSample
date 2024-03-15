//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.7.0
//     from Assets/GISSample/Misc/GISSampleInputActions.inputactions
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

public partial class @GISSampleInputActions: IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @GISSampleInputActions()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""GISSampleInputActions"",
    ""maps"": [
        {
            ""name"": ""GISSample"",
            ""id"": ""e5b8e29e-3654-4249-9e14-dd8648f8dbf0"",
            ""actions"": [
                {
                    ""name"": ""HorizontalMoveCameraByMouse"",
                    ""type"": ""Value"",
                    ""id"": ""fa426d65-f63f-4613-bf12-2404d0bd6912"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""HorizontalMoveCameraByKeyboard"",
                    ""type"": ""Value"",
                    ""id"": ""a8d58dbf-3b8d-4ae0-b6d6-c624e8654c61"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""VerticalMoveCameraByKeyboard"",
                    ""type"": ""Value"",
                    ""id"": ""e84d8a2b-1a21-465e-8a81-28a8e2409c0b"",
                    ""expectedControlType"": ""Double"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""RotateCamera"",
                    ""type"": ""Value"",
                    ""id"": ""1aca72dc-9921-4124-b45d-0c8cb4a6976e"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""ZoomCamera"",
                    ""type"": ""Value"",
                    ""id"": ""32641470-8ed9-4df7-90ef-04f321fa3e02"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""SelectObject"",
                    ""type"": ""Button"",
                    ""id"": ""3f91495c-1606-429c-9575-041b48dc1990"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Click"",
                    ""type"": ""Button"",
                    ""id"": ""3543b90c-5ad7-439f-8993-625ef6641210"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""One Modifier"",
                    ""id"": ""d68f7d60-960e-47ad-8789-da2b715ab2f0"",
                    ""path"": ""OneModifier"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""HorizontalMoveCameraByMouse"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""modifier"",
                    ""id"": ""6c1d3e2d-7480-4f12-a815-5135616443ec"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardAndMouse"",
                    ""action"": ""HorizontalMoveCameraByMouse"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""binding"",
                    ""id"": ""53daa96e-8b47-4d7c-bda8-3ffa9bf8fc3c"",
                    ""path"": ""<Mouse>/delta"",
                    ""interactions"": """",
                    ""processors"": ""ScaleVector2"",
                    ""groups"": ""KeyboardAndMouse"",
                    ""action"": ""HorizontalMoveCameraByMouse"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""One Modifier"",
                    ""id"": ""eeb2da9e-cf46-4794-b69e-8e53ff5fc023"",
                    ""path"": ""OneModifier"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardAndMouse"",
                    ""action"": ""RotateCamera"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""modifier"",
                    ""id"": ""e8f8fe38-4a3d-46fd-918d-9ab38320b6c9"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardAndMouse"",
                    ""action"": ""RotateCamera"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""binding"",
                    ""id"": ""18ea2163-1c3d-41fb-9775-d36b7554644f"",
                    ""path"": ""<Mouse>/delta"",
                    ""interactions"": """",
                    ""processors"": ""ScaleVector2(x=0.2,y=0.2)"",
                    ""groups"": ""KeyboardAndMouse"",
                    ""action"": ""RotateCamera"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""6005b4c5-be0b-44e5-bb27-dcf1e9f90680"",
                    ""path"": ""<Mouse>/scroll/y"",
                    ""interactions"": """",
                    ""processors"": ""Scale(factor=0.2)"",
                    ""groups"": """",
                    ""action"": ""ZoomCamera"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a0311b0a-e755-4723-a85a-c75d14cbe90d"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardAndMouse"",
                    ""action"": ""Click"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""442611f7-112e-4bda-9161-74e183216453"",
                    ""path"": ""<Mouse>/middleButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardAndMouse"",
                    ""action"": ""Click"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""74115321-a83f-4235-82d7-5e479b030377"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardAndMouse"",
                    ""action"": ""Click"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""69169da1-8496-46e4-a123-41bb827e82df"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": ""Tap"",
                    ""processors"": """",
                    ""groups"": ""KeyboardAndMouse"",
                    ""action"": ""SelectObject"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""9a83d29a-729e-49ad-b918-2de82752c6fa"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": ""ScaleVector2,InvertVector2"",
                    ""groups"": """",
                    ""action"": ""HorizontalMoveCameraByKeyboard"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""6f90ed0d-b4a3-41d6-9853-66ee50028d52"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardAndMouse"",
                    ""action"": ""HorizontalMoveCameraByKeyboard"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""5744214d-68d3-4253-abaf-a3913e3c0ebc"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardAndMouse"",
                    ""action"": ""HorizontalMoveCameraByKeyboard"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""c243971c-92a1-4a89-8669-59de1731a428"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardAndMouse"",
                    ""action"": ""HorizontalMoveCameraByKeyboard"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""cacc2f50-0b64-4db0-9c2b-451afc8030c8"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardAndMouse"",
                    ""action"": ""HorizontalMoveCameraByKeyboard"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""365695d6-0caa-479b-bf62-56fc1460e910"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""VerticalMoveCameraByKeyboard"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""a63758b2-125c-4ad2-9553-24cfbc38b4b2"",
                    ""path"": ""<Keyboard>/q"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""VerticalMoveCameraByKeyboard"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""23485e4b-4760-411c-8c0d-133f6765c347"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""VerticalMoveCameraByKeyboard"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""KeyboardAndMouse"",
            ""bindingGroup"": ""KeyboardAndMouse"",
            ""devices"": [
                {
                    ""devicePath"": ""<Mouse>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // GISSample
        m_GISSample = asset.FindActionMap("GISSample", throwIfNotFound: true);
        m_GISSample_HorizontalMoveCameraByMouse = m_GISSample.FindAction("HorizontalMoveCameraByMouse", throwIfNotFound: true);
        m_GISSample_HorizontalMoveCameraByKeyboard = m_GISSample.FindAction("HorizontalMoveCameraByKeyboard", throwIfNotFound: true);
        m_GISSample_VerticalMoveCameraByKeyboard = m_GISSample.FindAction("VerticalMoveCameraByKeyboard", throwIfNotFound: true);
        m_GISSample_RotateCamera = m_GISSample.FindAction("RotateCamera", throwIfNotFound: true);
        m_GISSample_ZoomCamera = m_GISSample.FindAction("ZoomCamera", throwIfNotFound: true);
        m_GISSample_SelectObject = m_GISSample.FindAction("SelectObject", throwIfNotFound: true);
        m_GISSample_Click = m_GISSample.FindAction("Click", throwIfNotFound: true);
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

    // GISSample
    private readonly InputActionMap m_GISSample;
    private List<IGISSampleActions> m_GISSampleActionsCallbackInterfaces = new List<IGISSampleActions>();
    private readonly InputAction m_GISSample_HorizontalMoveCameraByMouse;
    private readonly InputAction m_GISSample_HorizontalMoveCameraByKeyboard;
    private readonly InputAction m_GISSample_VerticalMoveCameraByKeyboard;
    private readonly InputAction m_GISSample_RotateCamera;
    private readonly InputAction m_GISSample_ZoomCamera;
    private readonly InputAction m_GISSample_SelectObject;
    private readonly InputAction m_GISSample_Click;
    public struct GISSampleActions
    {
        private @GISSampleInputActions m_Wrapper;
        public GISSampleActions(@GISSampleInputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @HorizontalMoveCameraByMouse => m_Wrapper.m_GISSample_HorizontalMoveCameraByMouse;
        public InputAction @HorizontalMoveCameraByKeyboard => m_Wrapper.m_GISSample_HorizontalMoveCameraByKeyboard;
        public InputAction @VerticalMoveCameraByKeyboard => m_Wrapper.m_GISSample_VerticalMoveCameraByKeyboard;
        public InputAction @RotateCamera => m_Wrapper.m_GISSample_RotateCamera;
        public InputAction @ZoomCamera => m_Wrapper.m_GISSample_ZoomCamera;
        public InputAction @SelectObject => m_Wrapper.m_GISSample_SelectObject;
        public InputAction @Click => m_Wrapper.m_GISSample_Click;
        public InputActionMap Get() { return m_Wrapper.m_GISSample; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(GISSampleActions set) { return set.Get(); }
        public void AddCallbacks(IGISSampleActions instance)
        {
            if (instance == null || m_Wrapper.m_GISSampleActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_GISSampleActionsCallbackInterfaces.Add(instance);
            @HorizontalMoveCameraByMouse.started += instance.OnHorizontalMoveCameraByMouse;
            @HorizontalMoveCameraByMouse.performed += instance.OnHorizontalMoveCameraByMouse;
            @HorizontalMoveCameraByMouse.canceled += instance.OnHorizontalMoveCameraByMouse;
            @HorizontalMoveCameraByKeyboard.started += instance.OnHorizontalMoveCameraByKeyboard;
            @HorizontalMoveCameraByKeyboard.performed += instance.OnHorizontalMoveCameraByKeyboard;
            @HorizontalMoveCameraByKeyboard.canceled += instance.OnHorizontalMoveCameraByKeyboard;
            @VerticalMoveCameraByKeyboard.started += instance.OnVerticalMoveCameraByKeyboard;
            @VerticalMoveCameraByKeyboard.performed += instance.OnVerticalMoveCameraByKeyboard;
            @VerticalMoveCameraByKeyboard.canceled += instance.OnVerticalMoveCameraByKeyboard;
            @RotateCamera.started += instance.OnRotateCamera;
            @RotateCamera.performed += instance.OnRotateCamera;
            @RotateCamera.canceled += instance.OnRotateCamera;
            @ZoomCamera.started += instance.OnZoomCamera;
            @ZoomCamera.performed += instance.OnZoomCamera;
            @ZoomCamera.canceled += instance.OnZoomCamera;
            @SelectObject.started += instance.OnSelectObject;
            @SelectObject.performed += instance.OnSelectObject;
            @SelectObject.canceled += instance.OnSelectObject;
            @Click.started += instance.OnClick;
            @Click.performed += instance.OnClick;
            @Click.canceled += instance.OnClick;
        }

        private void UnregisterCallbacks(IGISSampleActions instance)
        {
            @HorizontalMoveCameraByMouse.started -= instance.OnHorizontalMoveCameraByMouse;
            @HorizontalMoveCameraByMouse.performed -= instance.OnHorizontalMoveCameraByMouse;
            @HorizontalMoveCameraByMouse.canceled -= instance.OnHorizontalMoveCameraByMouse;
            @HorizontalMoveCameraByKeyboard.started -= instance.OnHorizontalMoveCameraByKeyboard;
            @HorizontalMoveCameraByKeyboard.performed -= instance.OnHorizontalMoveCameraByKeyboard;
            @HorizontalMoveCameraByKeyboard.canceled -= instance.OnHorizontalMoveCameraByKeyboard;
            @VerticalMoveCameraByKeyboard.started -= instance.OnVerticalMoveCameraByKeyboard;
            @VerticalMoveCameraByKeyboard.performed -= instance.OnVerticalMoveCameraByKeyboard;
            @VerticalMoveCameraByKeyboard.canceled -= instance.OnVerticalMoveCameraByKeyboard;
            @RotateCamera.started -= instance.OnRotateCamera;
            @RotateCamera.performed -= instance.OnRotateCamera;
            @RotateCamera.canceled -= instance.OnRotateCamera;
            @ZoomCamera.started -= instance.OnZoomCamera;
            @ZoomCamera.performed -= instance.OnZoomCamera;
            @ZoomCamera.canceled -= instance.OnZoomCamera;
            @SelectObject.started -= instance.OnSelectObject;
            @SelectObject.performed -= instance.OnSelectObject;
            @SelectObject.canceled -= instance.OnSelectObject;
            @Click.started -= instance.OnClick;
            @Click.performed -= instance.OnClick;
            @Click.canceled -= instance.OnClick;
        }

        public void RemoveCallbacks(IGISSampleActions instance)
        {
            if (m_Wrapper.m_GISSampleActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IGISSampleActions instance)
        {
            foreach (var item in m_Wrapper.m_GISSampleActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_GISSampleActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public GISSampleActions @GISSample => new GISSampleActions(this);
    private int m_KeyboardAndMouseSchemeIndex = -1;
    public InputControlScheme KeyboardAndMouseScheme
    {
        get
        {
            if (m_KeyboardAndMouseSchemeIndex == -1) m_KeyboardAndMouseSchemeIndex = asset.FindControlSchemeIndex("KeyboardAndMouse");
            return asset.controlSchemes[m_KeyboardAndMouseSchemeIndex];
        }
    }
    public interface IGISSampleActions
    {
        void OnHorizontalMoveCameraByMouse(InputAction.CallbackContext context);
        void OnHorizontalMoveCameraByKeyboard(InputAction.CallbackContext context);
        void OnVerticalMoveCameraByKeyboard(InputAction.CallbackContext context);
        void OnRotateCamera(InputAction.CallbackContext context);
        void OnZoomCamera(InputAction.CallbackContext context);
        void OnSelectObject(InputAction.CallbackContext context);
        void OnClick(InputAction.CallbackContext context);
    }
}
