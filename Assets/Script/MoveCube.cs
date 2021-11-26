using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCube : MonoBehaviour
{
    private void Start()
    {
        transform.DOMove(new Vector3(0, 5, 0),3).From().SetLoops(-1,LoopType.Yoyo);
    }
}
