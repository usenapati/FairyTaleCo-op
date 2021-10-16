// GENERATED AUTOMATICALLY FROM 'Assets/Scripts/InputScripts/WitchInputActions.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @WitchInputActions : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @WitchInputActions()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""WitchInputActions"",
    ""maps"": [
        {
            ""name"": ""Player"",
            ""id"": ""9a30f11a-279d-4bf6-8db0-02d00d62a054"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Button"",
                    ""id"": ""6513d9d0-6eca-439b-abcd-b97379657ff3"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""ce3981a2-dde5-48aa-8fac-13226c2aa70a"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""WASD"",
                    ""id"": ""d1058240-0a31-4879-8919-a71b62b48c90"",
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
                    ""id"": ""bad4afd3-eac6-43bd-b3d0-11fe43ea39a8"",
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
                    ""id"": ""5562492b-08e8-4495-a15e-c8de9b8b47ed"",
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
                    ""id"": ""f3fb1150-e8dc-4de3-a009-9d80ba49c624"",
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
                    ""id"": ""9ad98233-c659-4680-9f72-0d11e61f8423"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""fa808c0c-c856-4757-86b4-18587f86d67a"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""46301328-9783-49f5-8ceb-798b68f119c8"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b6e157b6-6ff5-4de5-b0d2-63bb337ad925"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""088faefe-57ed-42e0-8c27-b66c89024c1b"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Animations"",
            ""id"": ""ff4f8124-b395-46e2-86c1-91a7e91ec252"",
            ""actions"": [
                {
                    ""name"": ""Dance"",
                    ""type"": ""Button"",
                    ""id"": ""879d347a-e651-45b1-9838-d85fdcbbce9e"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Winner"",
                    ""type"": ""Button"",
                    ""id"": ""6b2fafa3-e342-4939-aef2-af098a279457"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Loser"",
                    ""type"": ""Button"",
                    ""id"": ""416a1339-83f1-4b93-bc02-fccb280297c0"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""b556e880-9857-4067-b21f-aedde21030c3"",
                    ""path"": ""<Keyboard>/1"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Dance"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""919bf090-13d6-42a7-9c32-ef9089fe5f14"",
                    ""path"": ""<Keyboard>/2"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Winner"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ddefc0e7-db56-4750-90b0-f6295e97d77e"",
                    ""path"": ""<Keyboard>/3"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Loser"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Player
        m_Player = asset.FindActionMap("Player", throwIfNotFound: true);
        m_Player_Move = m_Player.FindAction("Move", throwIfNotFound: true);
        m_Player_Jump = m_Player.FindAction("Jump", throwIfNotFound: true);
        // Animations
        m_Animations = asset.FindActionMap("Animations", throwIfNotFound: true);
        m_Animations_Dance = m_Animations.FindAction("Dance", throwIfNotFound: true);
        m_Animations_Winner = m_Animations.FindAction("Winner", throwIfNotFound: true);
        m_Animations_Loser = m_Animations.FindAction("Loser", throwIfNotFound: true);
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

    // Player
    private readonly InputActionMap m_Player;
    private IPlayerActions m_PlayerActionsCallbackInterface;
    private readonly InputAction m_Player_Move;
    private readonly InputAction m_Player_Jump;
    public struct PlayerActions
    {
        private @WitchInputActions m_Wrapper;
        public PlayerActions(@WitchInputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_Player_Move;
        public InputAction @Jump => m_Wrapper.m_Player_Jump;
        public InputActionMap Get() { return m_Wrapper.m_Player; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerActions instance)
        {
            if (m_Wrapper.m_PlayerActionsCallbackInterface != null)
            {
                @Move.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMove;
                @Jump.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnJump;
            }
            m_Wrapper.m_PlayerActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
            }
        }
    }
    public PlayerActions @Player => new PlayerActions(this);

    // Animations
    private readonly InputActionMap m_Animations;
    private IAnimationsActions m_AnimationsActionsCallbackInterface;
    private readonly InputAction m_Animations_Dance;
    private readonly InputAction m_Animations_Winner;
    private readonly InputAction m_Animations_Loser;
    public struct AnimationsActions
    {
        private @WitchInputActions m_Wrapper;
        public AnimationsActions(@WitchInputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @Dance => m_Wrapper.m_Animations_Dance;
        public InputAction @Winner => m_Wrapper.m_Animations_Winner;
        public InputAction @Loser => m_Wrapper.m_Animations_Loser;
        public InputActionMap Get() { return m_Wrapper.m_Animations; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(AnimationsActions set) { return set.Get(); }
        public void SetCallbacks(IAnimationsActions instance)
        {
            if (m_Wrapper.m_AnimationsActionsCallbackInterface != null)
            {
                @Dance.started -= m_Wrapper.m_AnimationsActionsCallbackInterface.OnDance;
                @Dance.performed -= m_Wrapper.m_AnimationsActionsCallbackInterface.OnDance;
                @Dance.canceled -= m_Wrapper.m_AnimationsActionsCallbackInterface.OnDance;
                @Winner.started -= m_Wrapper.m_AnimationsActionsCallbackInterface.OnWinner;
                @Winner.performed -= m_Wrapper.m_AnimationsActionsCallbackInterface.OnWinner;
                @Winner.canceled -= m_Wrapper.m_AnimationsActionsCallbackInterface.OnWinner;
                @Loser.started -= m_Wrapper.m_AnimationsActionsCallbackInterface.OnLoser;
                @Loser.performed -= m_Wrapper.m_AnimationsActionsCallbackInterface.OnLoser;
                @Loser.canceled -= m_Wrapper.m_AnimationsActionsCallbackInterface.OnLoser;
            }
            m_Wrapper.m_AnimationsActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Dance.started += instance.OnDance;
                @Dance.performed += instance.OnDance;
                @Dance.canceled += instance.OnDance;
                @Winner.started += instance.OnWinner;
                @Winner.performed += instance.OnWinner;
                @Winner.canceled += instance.OnWinner;
                @Loser.started += instance.OnLoser;
                @Loser.performed += instance.OnLoser;
                @Loser.canceled += instance.OnLoser;
            }
        }
    }
    public AnimationsActions @Animations => new AnimationsActions(this);
    public interface IPlayerActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
    }
    public interface IAnimationsActions
    {
        void OnDance(InputAction.CallbackContext context);
        void OnWinner(InputAction.CallbackContext context);
        void OnLoser(InputAction.CallbackContext context);
    }
}
