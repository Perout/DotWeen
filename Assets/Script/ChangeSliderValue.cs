using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class ChangeSliderValue : MonoBehaviour
{
    [SerializeField] private Slider _slider;
    private void Start()
    {
        _slider.DOValue(1, 2).SetLoops(-1, LoopType.Yoyo);
    }
}
