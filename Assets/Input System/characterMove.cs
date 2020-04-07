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
                    ""name"": ""Interact"",
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
                    ""name"": ""New action"",
                    ""type"": ""Button"",
                    ""id"": ""349af121-1fe9-4c95-b608-2d3eb4092d8d"",
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
                    ""action"": ""Interact"",
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
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""New action"",
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
        m_Character_Interact = m_Character.FindAction("Interact", throwIfNotFound: true);
        m_Character_Ignore = m_Character.FindAction("Ignore", throwIfNotFound: true);
        m_Character_Newaction = m_Character.FindAction("New action", throwIfNotFound: true);
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
    private readonly InputAction m_Character_Interact;
    private readonly InputAction m_Character_Ignore;
    private readonly InputAction m_Character_Newaction;
    public struct CharacterActions
    {
        private @CharacterMove m_Wrapper;
        public CharacterActions(@CharacterMove wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_Character_Move;
        public InputAction @Interact => m_Wrapper.m_Character_Interact;
        public InputAction @Ignore => m_Wrapper.m_Character_Ignore;
        public InputAction @Newaction => m_Wrapper.m_Character_Newaction;
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
                @Interact.started -= m_Wrapper.m_CharacterActionsCallbackInterface.OnInteract;
                @Interact.performed -= m_Wrapper.m_CharacterActionsCallbackInterface.OnInteract;
                @Interact.canceled -= m_Wrapper.m_CharacterActionsCallbackInterface.OnInteract;
                @Ignore.started -= m_Wrapper.m_CharacterActionsCallbackInterface.OnIgnore;
                @Ignore.performed -= m_Wrapper.m_CharacterActionsCallbackInterface.OnIgnore;
                @Ignore.canceled -= m_Wrapper.m_CharacterActionsCallbackInterface.OnIgnore;
                @Newaction.started -= m_Wrapper.m_CharacterActionsCallbackInterface.OnNewaction;
                @Newaction.performed -= m_Wrapper.m_CharacterActionsCallbackInterface.OnNewaction;
                @Newaction.canceled -= m_Wrapper.m_CharacterActionsCallbackInterface.OnNewaction;
            }
            m_Wrapper.m_CharacterActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
                @Interact.started += instance.OnInteract;
                @Interact.performed += instance.OnInteract;
                @Interact.canceled += instance.OnInteract;
                @Ignore.started += instance.OnIgnore;
                @Ignore.performed += instance.OnIgnore;
                @Ignore.canceled += instance.OnIgnore;
                @Newaction.started += instance.OnNewaction;
                @Newaction.performed += instance.OnNewaction;
                @Newaction.canceled += instance.OnNewaction;
            }
        }
    }
    public CharacterActions @Character => new CharacterActions(this);
    public interface ICharacterActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnInteract(InputAction.CallbackContext context);
        void OnIgnore(InputAction.CallbackContext context);
        void OnNewaction(InputAction.CallbackContext context);
    }
}
