// GENERATED AUTOMATICALLY FROM 'Assets/Scripts/InputScripts/DialogueActions.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @DialogueActions : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @DialogueActions()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""DialogueActions"",
    ""maps"": [
        {
            ""name"": ""UI"",
            ""id"": ""c573a71f-481e-4cda-baf0-62ed80932528"",
            ""actions"": [
                {
                    ""name"": ""AdvanceDialogue"",
                    ""type"": ""Button"",
                    ""id"": ""b425cff3-55b2-4922-b8c8-42b11487b745"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""bf254156-e1ee-4497-9056-2a791e4208b2"",
                    ""path"": ""<Gamepad>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""AdvanceDialogue"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""194d08cb-e5b0-4212-911d-aa64299ce959"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""AdvanceDialogue"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // UI
        m_UI = asset.FindActionMap("UI", throwIfNotFound: true);
        m_UI_AdvanceDialogue = m_UI.FindAction("AdvanceDialogue", throwIfNotFound: true);
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

    // UI
    private readonly InputActionMap m_UI;
    private IUIActions m_UIActionsCallbackInterface;
    private readonly InputAction m_UI_AdvanceDialogue;
    public struct UIActions
    {
        private @DialogueActions m_Wrapper;
        public UIActions(@DialogueActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @AdvanceDialogue => m_Wrapper.m_UI_AdvanceDialogue;
        public InputActionMap Get() { return m_Wrapper.m_UI; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(UIActions set) { return set.Get(); }
        public void SetCallbacks(IUIActions instance)
        {
            if (m_Wrapper.m_UIActionsCallbackInterface != null)
            {
                @AdvanceDialogue.started -= m_Wrapper.m_UIActionsCallbackInterface.OnAdvanceDialogue;
                @AdvanceDialogue.performed -= m_Wrapper.m_UIActionsCallbackInterface.OnAdvanceDialogue;
                @AdvanceDialogue.canceled -= m_Wrapper.m_UIActionsCallbackInterface.OnAdvanceDialogue;
            }
            m_Wrapper.m_UIActionsCallbackInterface = instance;
            if (instance != null)
            {
                @AdvanceDialogue.started += instance.OnAdvanceDialogue;
                @AdvanceDialogue.performed += instance.OnAdvanceDialogue;
                @AdvanceDialogue.canceled += instance.OnAdvanceDialogue;
            }
        }
    }
    public UIActions @UI => new UIActions(this);
    public interface IUIActions
    {
        void OnAdvanceDialogue(InputAction.CallbackContext context);
    }
}
