using UnityEngine;
using Valve.VR.InteractionSystem;

public class CraneUpDownMovingHandler : MonoBehaviour
{
    [SerializeField] private HoverButton _upButton;
    [SerializeField] private float _upSpeed = 1f;
    [SerializeField] private HoverButton _downButton;
    [SerializeField] private float _downSpeed = 1f;
    
    private void Awake()
    {
        _upButton.onButtonIsPressed.AddListener(OnUpButtonPressed);
        _downButton.onButtonIsPressed.AddListener(OnDownButtonPressed);
    }
    private void OnUpButtonPressed(Hand hand)
    {
        transform.position += Vector3.up * _upSpeed * Time.deltaTime;
    }
    private void OnDownButtonPressed(Hand hand)
    {
        transform.position += Vector3.down * _downSpeed * Time.deltaTime;
    }
}
