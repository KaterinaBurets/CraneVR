using UnityEngine;
using UnityEngine.EventSystems;
using Valve.VR.InteractionSystem;

public class OnOffButtonHandler : MonoBehaviour
{
    [SerializeField] private HoverButton _onOffButton;
    [SerializeField] private float _holdTime = 3f; 
    [SerializeField] private MeshRenderer _displayRenderer;
    [SerializeField] private Material _greenMaterial;
    [SerializeField] private Material _blackMaterial;

    private bool _isPressed = false;
    private float _pressTimer = 0f; 
    private bool _isDisplayOn = false;

    public bool IsDisplayOn => _isDisplayOn;
    private void Awake()
    {
        _onOffButton.onButtonDown.AddListener(OnButtonDown);
        _onOffButton.onButtonUp.AddListener(OnButtonUp);
    }

    private void OnButtonDown(Hand hand)
    {
        _isPressed = true;
        _pressTimer = 0f;
    }

    private void OnButtonUp(Hand hand)
    {
        _isPressed = false;
        _pressTimer = 0f;
    }

    private void Update()
    {
        if (_isPressed)
        {
            _pressTimer += Time.deltaTime;

            if (_pressTimer >= _holdTime)
            {
                _isPressed = false;
                DoAction();
            }
        }
    }

    private void DoAction()
    {
        if (!_isDisplayOn)
        {
            _displayRenderer.material = _greenMaterial;
            _isDisplayOn = true;
        }
        else
        {
            _displayRenderer.material = _blackMaterial;
            _isDisplayOn = false;
        }
    }
}
