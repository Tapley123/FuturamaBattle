using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCamera : MonoBehaviour
{
    [SerializeField] private Transform targetT;

    float t;
    Vector3 startPosition;
    Vector3 target;
    public float timeToReachTarget = 3f;
    void Start()
    {
        startPosition = target = transform.position;

        SetDestination(targetT.position, timeToReachTarget);
    }
    void Update()
    {
        t += Time.deltaTime / timeToReachTarget;
        transform.position = Vector3.Lerp(startPosition, target, t);
    }
    public void SetDestination(Vector3 destination, float time)
    {
        t = 0;
        startPosition = transform.position;
        timeToReachTarget = time;
        target = destination;
    }
}
