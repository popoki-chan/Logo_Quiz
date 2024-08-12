using DG.Tweening;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class Alphabet : MonoBehaviour
{
    public RectTransform rectTransform;
    public Image image;
    public Button button;
    public Blank target;
    
    public void OnEnable()
    {
        rectTransform = GetComponent<RectTransform>();
        image = GetComponent<Image>();
        button = GetComponent<Button>();
        button.onClick.AddListener(FillBlank);
    }

    private void FillBlank()
    {
        StageManager.Instance.GetFirstNotFilledBlank(this);
        target.isFilled = true;
        //use DotTween
        rectTransform.DOAnchorPos(target.rectTransform.anchoredPosition, 0.5f);
        
    }

    public void SetTarget(Blank blank)
    {
        target = blank;
        
    }
    
    
}
