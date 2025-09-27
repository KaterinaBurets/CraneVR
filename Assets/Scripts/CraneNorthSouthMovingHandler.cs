using UnityEngine;
using Valve.VR.InteractionSystem;

public class CraneNorthSouthMovingHandler : MonoBehaviour
{
    [SerializeField] private HoverButton _northButton;
    [SerializeField] private float _northSpeed = 1f;
    [SerializeField] private HoverButton _southButton;
    [SerializeField] private float _southSpeed = 1f;

    private void Awake()
    {
        _northButton.onButtonIsPressed.AddListener(OnNorthButtonPressed);
        _southButton.onButtonIsPressed.AddListener(OnSouthButtonPressed);
    }
    private void OnNorthButtonPressed(Hand hand)
    {
        transform.position += Vector3.forward * _northSpeed * Time.deltaTime;
    }
    private void OnSouthButtonPressed(Hand hand)
    {
        transform.position += Vector3.back * _southSpeed * Time.deltaTime;
    }
}
