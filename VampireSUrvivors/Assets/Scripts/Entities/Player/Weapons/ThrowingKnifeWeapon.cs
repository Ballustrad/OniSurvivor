using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThrowingKnifeWeapon : WeaponBase
{
    
    [SerializeField] GameObject knifePrefabRight;
    [SerializeField] GameObject knifePrefabLeft;

    PlayerMove playerMove;

    private void Awake()
    {
        playerMove = GetComponentInParent<PlayerMove>();
    }


    

    

    public override void Attack()
    {
        if (playerMove.lastHorizontalVector == 1)
        {
            GameObject thrownKnife = Instantiate(knifePrefabRight);
            thrownKnife.transform.position = transform.position;
            thrownKnife.GetComponent<ThrowingKnifeProjectile>().SetDirection(playerMove.lastHorizontalVector, 0f);
        }
        else if (playerMove.lastHorizontalVector == -1)
        {
            GameObject thrownKnife = Instantiate(knifePrefabLeft);
            thrownKnife.transform.position = transform.position;
            thrownKnife.GetComponent<ThrowingKnifeProjectile>().SetDirection(playerMove.lastHorizontalVector, 0f);
        }
    }
}
