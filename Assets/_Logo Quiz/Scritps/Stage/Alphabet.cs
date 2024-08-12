using UnityEngine;
using UnityEngine.UI;

public class Alphabet : MonoBehaviour
{
    public RectTransform rectTransform;
    public Image image;
    public Button button;
    
    public void OnEnable()
    {
        rectTransform = GetComponent<RectTransform>();
        image = GetComponent<Image>();
        button = GetComponent<Button>();
    }
}
