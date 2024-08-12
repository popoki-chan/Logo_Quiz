using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.UI;

public class StageManager : Singleton<StageManager>
{
    public StageData data;
    public Blank blankPrefab;
    public Alphabet alphabetPrefab;
    public HorizontalLayoutGroup blankGroup;
    public GridLayoutGroup alphabetGroup;

    public List<Blank> blankList;
    public List<Alphabet> alphabetList;
    
    public void Init()
    {
        
    }

    private void OnEnable()
    {
        CreateBlanks();
        CreateAlphabets();
        StartCoroutine(DeActiveLayoutGroup());
    }

    public void CreateBlanks()
    {
        for (int i = 0; i < data.blankNumber; i++)
        {
            var blank = PoolingManager.Spawn(blankPrefab, transform.position, Quaternion.identity);
            blank.transform.SetParent(blankGroup.GetComponent<RectTransform>());
            blank.transform.localScale = Vector3.one;
            blank.name = "Blank" + (i + 1);
            blankList.Add(blank);
        }
    }

    public void CreateAlphabets()
    {
        for (int i = 0; i < data.alphabets.Count; i++)
        {
            var alphabet = PoolingManager.Spawn(alphabetPrefab, transform.position, Quaternion.identity);
            alphabet.transform.SetParent(alphabetGroup.GetComponent<RectTransform>());
            alphabet.transform.localScale = Vector3.one;
            alphabet.name = "Alphabet" + (i + 1);
            alphabet.image.sprite = data.alphabets[i];
            alphabetList.Add(alphabet);
        }
    }

    public void GetFirstNotFilledBlank(Alphabet alphabet)
    {
        for (int i = 0; i < blankList.Count; i++)
        {
            if (!blankList[i].isFilled)
            {
                alphabet.transform.SetParent(blankGroup.transform);
                alphabet.SetTarget(blankList[i]);
                break;
            }
        }
        
    }

    private IEnumerator DeActiveLayoutGroup()
    {
        yield return null;
        yield return null;
        blankGroup.enabled = false;
        alphabetGroup.enabled = false;
    }
    
}
