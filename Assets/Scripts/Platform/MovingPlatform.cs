using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
    [SerializeField] private Transform pos1, pos2;
    [SerializeField][Range(0F, 20F)] private float speed;
    [SerializeField] private Transform startPos;
    Vector3 nextPos;

    void Start()
    {
        nextPos = startPos.position;
    }
    
    void Update()
    {
        if(transform.position == pos1.position)
        {
            nextPos = pos2.position;
        }
        else if (transform.position == pos2.position)
        {
            nextPos = pos1.position;
        }

        transform.position = Vector3.MoveTowards(transform.position, nextPos, speed * Time.deltaTime);
    }

    private void OnDrawGizmos()
    {
        Gizmos.DrawLine(pos1.position, pos2.position);
    }
}
