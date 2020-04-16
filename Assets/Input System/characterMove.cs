// GENERATED AUTOMATICALLY FROM 'Assets/Input System/characterMove.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @CharacterMove : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @CharacterMove()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""characterMove"",
    ""maps"": [
        {
            ""name"": ""Character"",
            ""id"": ""420a648e-e682-4794-a13e-c555c73dcc04"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""f72d0830-0528-4a87-82e9-d06590151c06"",
                    ""expectedControlType"": ""Stick"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Multi Function"",
                    ""type"": ""Button"",
                    ""id"": ""bf745a40-4fe5-4afb-94de-df93829a12fa"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""Ignore"",
                    ""type"": ""Button"",
                    ""id"": ""c8575d11-dff5-4600-b891-f50d581ba6ed"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press(behavior=2)""
                },
                {
                    ""name"": ""Select Button"",
                    ""type"": ""Button"",
                    ""id"": ""349af121-1fe9-4c95-b608-2d3eb4092d8d"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": ""Press(behavior=2)""
                },
                {
                    ""name"": ""Vertical "",
                    ""type"": ""Button"",
                    ""id"": ""349559f0-c3f6-4bb7-8946-96e779f28ed0"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": ""Press(behavior=2)""
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""065b3f8a-cf3d-4b5d-a50c-99584187e0c6"",
                    ""path"": ""<HID::Twin USB Gamepad      >/stick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8749d9d0-a330-446d-97b0-454be9ad006f"",
                    ""path"": ""<HID::Twin USB Gamepad      >/button3"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Multi Function"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ce560131-e5f5-4bdb-8e61-362c58e035e8"",
                    ""path"": ""<HID::Twin USB Gamepad      >/button2"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Ignore"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9ac04934-ee1b-4a94-b416-634b4fcae608"",
                    ""path"": ""<HID::Twin USB Gamepad      >/button9"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Select Button"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f1772430-2889-4f9d-837d-e74859123803"",
                    ""path"": ""<HID::Twin USB Gamepad      >/hat/y"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Vertical "",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Character
        m_Character = asset.FindActionMap("Character", throwIfNotFound: true);
        m_Character_Move = m_Character.FindAction("Move", throwIfNotFound: true);
        m_Character_MultiFunction = m_Character.FindAction("Multi Function", throwIfNotFound: true);
        m_Character_Ignore = m_Character.FindAction("Ignore", throwIfNotFound: true);
        m_Character_SelectButton = m_Character.FindAction("Select Button", throwIfNotFound: true);
        m_Character_Vertical = m_Character.FindAction("Vertical ", throwIfNotFound: true);
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

    // Character
    private readonly InputActionMap m_Character;
    private ICharacterActions m_CharacterActionsCallbackInterface;
    private readonly InputAction m_Character_Move;
    private readonly InputAction m_Character_MultiFunction;
    private readonly InputAction m_Character_Ignore;
    private readonly InputAction m_Character_SelectButton;
    private readonly InputAction m_Character_Vertical;
    public struct CharacterActions
    {
        private @CharacterMove m_Wrapper;
        public CharacterActions(@CharacterMove wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_Character_Move;
        public InputAction @MultiFunction => m_Wrapper.m_Character_MultiFunction;
        public InputAction @Ignore => m_Wrapper.m_Character_Ignore;
        public InputAction @SelectButton => m_Wrapper.m_Character_SelectButton;
        public InputAction @Vertical => m_Wrapper.m_Character_Vertical;
        public InputActionMap Get() { return m_Wrapper.m_Character; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(CharacterActions set) { return set.Get(); }
        public void SetCallbacks(ICharacterActions instance)
        {
            if (m_Wrapper.m_CharacterActionsCallbackInterface != null)
            {
                @Move.started -= m_Wrapper.m_CharacterActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_CharacterActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_CharacterActionsCallbackInterface.OnMove;
                @MultiFunction.started -= m_Wrapper.m_CharacterActionsCallbackInterface.OnMultiFunction;
                @MultiFunction.performed -= m_Wrapper.m_CharacterActionsCallbackInterface.OnMultiFunction;
                @MultiFunction.canceled -= m_Wrapper.m_CharacterActionsCallbackInterface.OnMultiFunction;
                @Ignore.started -= m_Wrapper.m_CharacterActionsCallbackInterface.OnIgnore;
                @Ignore.performed -= m_Wrapper.m_CharacterActionsCallbackInterface.OnIgnore;
                @Ignore.canceled -= m_Wrapper.m_CharacterActionsCallbackInterface.OnIgnore;
                @SelectButton.started -= m_Wrapper.m_CharacterActionsCallbackInterface.OnSelectButton;
                @SelectButton.performed -= m_Wrapper.m_CharacterActionsCallbackInterface.OnSelectButton;
                @SelectButton.canceled -= m_Wrapper.m_CharacterActionsCallbackInterface.OnSelectButton;
                @Vertical.started -= m_Wrapper.m_CharacterActionsCallbackInterface.OnVertical;
                @Vertical.performed -= m_Wrapper.m_CharacterActionsCallbackInterface.OnVertical;
                @Vertical.canceled -= m_Wrapper.m_CharacterActionsCallbackInterface.OnVertical;
            }
            m_Wrapper.m_CharacterActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
                @MultiFunction.started += instance.OnMultiFunction;
                @MultiFunction.performed += instance.OnMultiFunction;
                @MultiFunction.canceled += instance.OnMultiFunction;
                @Ignore.started += instance.OnIgnore;
                @Ignore.performed += instance.OnIgnore;
                @Ignore.canceled += instance.OnIgnore;
                @SelectButton.started += instance.OnSelectButton;
                @SelectButton.performed += instance.OnSelectButton;
                @SelectButton.canceled += instance.OnSelectButton;
                @Vertical.started += instance.OnVertical;
                @Vertical.performed += instance.OnVertical;
                @Vertical.canceled += instance.OnVertical;
            }
        }
    }
    public CharacterActions @Character => new CharacterActions(this);
    public interface ICharacterActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnMultiFunction(InputAction.CallbackContext context);
        void OnIgnore(InputAction.CallbackContext context);
        void OnSelectButton(InputAction.CallbackContext context);
        void OnVertical(InputAction.CallbackContext context);
    }
}
