using UnityEngine;
using TMPro;

public class CanvasNextHandler : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _canvasText;
    [SerializeField] private GameObject _canvas;
    public void GAText()
    {
        _canvas.SetActive(true);
        _canvasText.text = "Чтобы взять объект зажмите верхнюю клавишу контроллера";
    }
    public void RCText()
    {
        _canvas.SetActive(true);
        _canvasText.text = "Чтобы управлять пультом нажмите кнопку";
    }
    public void Detouched()
    {
        _canvas.SetActive(false);
        _canvasText.text = "";
    }
}
