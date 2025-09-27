using UnityEngine;
using Valve.VR.InteractionSystem;


public class CraneEastWestMovingHandler : MonoBehaviour
{
    [SerializeField] private HoverButton _eastButton;
    [SerializeField] private float _eastSpeed = 1f;
    [SerializeField] private HoverButton _westButton;
    [SerializeField] private float _westSpeed = 1f;

    private void Awake()
    {
        _eastButton.onButtonIsPressed.AddListener(OnEastButtonPressed);
        _westButton.onButtonIsPressed.AddListener(OnWestButtonPressed);
    }
    private void OnEastButtonPressed(Hand hand)
    {
        transform.position += Vector3.left * _eastSpeed * Time.deltaTime;
    }
    private void OnWestButtonPressed(Hand hand)
    {
        transform.position += Vector3.right * _westSpeed * Time.deltaTime;
    }
}
