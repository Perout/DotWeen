using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class ChangeText : MonoBehaviour
{
    [SerializeField] private Text _text1;
    [SerializeField] private Text _text2;
    [SerializeField] private Text _text3;
    private void Start()
    {
        _text1.DOText("Замена текса",3);
        _text2.DOText("Дополнить текст", 1).SetRelative();
        _text3.DOText("Я взломал текст", 3, true, ScrambleMode.All);
        _text3.DOColor(Color.red,3);
    }
}
