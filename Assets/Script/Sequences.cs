using DG.Tweening;

using UnityEngine;

public class Sequences : MonoBehaviour
{
    private void Start()
    {
        Sequence sequences = DOTween.Sequence();
        sequences.Append(transform.DOMoveY(3, 4).SetRelative());
        sequences.Insert(0, transform.DORotate(new Vector3(60, 15,0), 2));


        sequences.Append(transform.DOMoveX(3, 4).SetRelative());
        sequences.Insert(4, transform.DORotate(new Vector3(0, 40, 15), 2));

        sequences.SetLoops(-1, LoopType.Yoyo);

    }
}

