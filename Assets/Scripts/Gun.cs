﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    private GameObject target;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) // 마우스 눌렀을때 처리
        {
            CastRay();
            if (target != null)
            {
                if (target.tag == "Chicken") // 타겟이 치킨이라면 실행
                {
                    Debug.Log("Chicken!");
                    target.GetComponent<Chicken>().KillChicken();
                    
                }
                else
                {
                    Debug.Log("Click!");
                }
            }
        }
    }
    void CastRay()  // 레이를 쏴서 유닛 히트처리
    {
        target = null;

        Vector2 pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        RaycastHit2D hit = Physics2D.Raycast(pos, Vector2.zero, 0f);

        if (hit.collider != null)    // 히트되었다면 실행
        {
            target = hit.collider.gameObject;   // 히트 된 게임 오브젝트를 타겟으로 지정
        }
    }
}
