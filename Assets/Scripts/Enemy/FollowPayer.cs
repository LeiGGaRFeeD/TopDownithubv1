using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPayer : MonoBehaviour
{
    [SerializeField] private PlayerDetector _playerDetector;
    [SerializeField] private Rigidbody2D _rigidbody2D;
    [SerializeField] private List<Vector2> _followPoints = new List<Vector2>();
    [SerializeField] private float _getPointDelay;
    [SerializeField] private float _speed;
    private Vector2 _moveTo;
    private float _time;
    private int _lastPoint;

    private void FixedUpdate()
    {
        if (_playerDetector.Player)
        {
            MoveToPlayer();
            UpdatePoints();
        }
        else if (_lastPoint > 0)
        {
            MoveToLastPoint();
            LookAtPoint();
        }
    }

    private void LookAtPoint()
    {
        float angle = Mathf.Atan2(_followPoints[_lastPoint].y, _followPoints[_lastPoint].x) * Mathf.Rad2Deg - 90;
        _rigidbody2D.rotation = angle;
    }
    private void MoveToPlayer()
    {
        _moveTo = (_playerDetector.Player.transform.position - _rigidbody2D.transform.position).normalized;
        _rigidbody2D.MovePosition(_rigidbody2D.position + _moveTo * _speed * Time.fixedDeltaTime);
    }

    private void MoveToLastPoint()
    {
        _moveTo = (_followPoints[_lastPoint] - _rigidbody2D.position).normalized;
        _rigidbody2D.MovePosition(_rigidbody2D.position + _moveTo * _speed * Time.fixedDeltaTime);
        Vector2 dif = _followPoints[_lastPoint] - _rigidbody2D.position;
        if (dif.magnitude < 0.2f && _lastPoint > 0)
        {
            _followPoints.RemoveAt(_lastPoint);
            _lastPoint--;
        }
    }

    private void UpdatePoints()
    {
        if (_time < 0)
        {
            SetNewFollowPoint();
            _lastPoint = _followPoints.Count - 1;
            _time = _getPointDelay;
        }
        else
        {
            _time -= Time.deltaTime;
        }
    }

    public void SetNewFollowPoint()
    {
        _followPoints.Add(_rigidbody2D.position);
    }
}
