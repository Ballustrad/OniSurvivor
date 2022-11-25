using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhipWeapon : MonoBehaviour
{
    [SerializeField] float timeToAttack = 4f;
    float timer;

    [SerializeField] GameObject leftWhipObject;
    [SerializeField] GameObject rightWhipObject;

    PlayerMove playerMove;
    [SerializeField] Vector2 whipAttackSize;

    private void Awake()
    {
        playerMove = GetComponentInParent<PlayerMove>();
    }

    private void Update()
    {
        timer -= Time.deltaTime;
        if (timer < 0f)
        {
            Attack();
        }
    }

    private void Attack()
    {
        
        timer = timeToAttack;

        if(playerMove.lastHorizontalVector > 0)
        {
            rightWhipObject.SetActive(true);
            Physics2D.OverlapBoxAll(leftWhipObject.transform.position, whipAttackSize);
        }
        else
        { 
            leftWhipObject.SetActive(true);
        }
    }
}
