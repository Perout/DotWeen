using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class FolllowerMove : MonoBehaviour
{
    [SerializeField] private Transform _target;
    private Vector3 _targetLastPosition;
    private Tween _tween;
    private void Start()
    {
        _tween = transform.DOMove(_target.position, 2).SetAutoKill(false);
        _targetLastPosition = _target.position;
    }
    private void Update()
    {
        if (_targetLastPosition !=_target.position)
        {
            //_tween.ChangeEndValue(_target.position, true);
            _targetLastPosition = _target.position;
        }
    }
}
