using UnityEngine;

public class Blank : MonoBehaviour
{
    public RectTransform rectTransform;

    public void OnEnable()
    {
        rectTransform = GetComponent<RectTransform>();
    }
}
