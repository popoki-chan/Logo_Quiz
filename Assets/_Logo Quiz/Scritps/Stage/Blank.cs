using UnityEngine;

public class Blank : MonoBehaviour
{
    public RectTransform rectTransform;
    public bool isFilled = false;
    public void OnEnable()
    {
        rectTransform = GetComponent<RectTransform>();
    }
}
