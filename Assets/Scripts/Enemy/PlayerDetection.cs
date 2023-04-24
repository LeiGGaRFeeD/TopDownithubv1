using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDetection : MonoBehaviour
{
    [SerializeField] private float _radius;
    [Range(0, 360)][SerializeField] private float _angle;
    [SerializeField] private LayerMask _targetMask;
    [SerializeField] private LayerMask _obstructionMask;

    [SerializeField] private bool _canSeePlayer;
    private GameObject _player;
    public GameObject Player => _player;

    private void Update()
    {
        FieldOfViewCheck();
    }


    private void FieldOfViewCheck()
    {
        Collider2D rangeCheck = Physics2D.OverlapCircle(new Vector2(transform.position.x, transform.position.y), _radius, _targetMask);

        if (rangeCheck != null)
        {
            Transform target = rangeCheck.transform;
            Vector2 directionToTarget = (target.position - transform.position).normalized;

            if (Vector2.Angle(transform.up, directionToTarget) < _angle / 2)
            {
                float distanceToTarget = Vector2.Distance(transform.position, target.position);

                if (!Physics2D.Raycast(transform.position, directionToTarget, distanceToTarget, _obstructionMask))
                    SeePlayer(true, target.gameObject);
                else
                    SeePlayer(false);
            }
            else
                SeePlayer(false);

        }
        else if (_canSeePlayer)
        {
            SeePlayer(false);
        }
    }

    private void SeePlayer(bool see, GameObject player = null)
    {
        _canSeePlayer = see;
        _player = player;
    }

    private void OnDrawGizmos()
    {
        Gizmos.DrawWireSphere(new Vector3(transform.position.x, transform.position.y, transform.position.z), _radius);
        Gizmos.color = Color.blue;
        Gizmos.DrawLine(transform.position, transform.position + DirectionFromAngle(-transform.eulerAngles.z, -_angle / 2) * _radius);
        Gizmos.DrawLine(transform.position, transform.position + DirectionFromAngle(-transform.eulerAngles.z, _angle / 2) * _radius);

        if (_canSeePlayer)
        {
            Gizmos.color = Color.green;
            Debug.Log("PlayerSee!!!");
        //    Gizmos.DrawLine(transform.position, Player.transform.position);
        }
    }
    private Vector3 DirectionFromAngle(float eulerY, float angleInDegrees)
    {
        angleInDegrees += eulerY;
        return new Vector3(Mathf.Sin(angleInDegrees * Mathf.Deg2Rad), Mathf.Cos(angleInDegrees * Mathf.Deg2Rad));
    }
}
