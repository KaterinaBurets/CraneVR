using TMPro;
using UnityEngine;

public class DistanceToDangerZoneHandler : MonoBehaviour
{
    [SerializeField] private OnOffButtonHandler _onOffButtonHandler;
    [SerializeField] Transform _gazAnalyzer;
    [SerializeField] Transform _dangerZone;
    [SerializeField] TextMeshPro _countText;

    private void Update()
    {
        if (_onOffButtonHandler.IsDisplayOn == true)
        {
            float distance = Vector3.Distance(_gazAnalyzer.position, _dangerZone.position);
            _countText.text = distance.ToString();
        }
        
    }
}
