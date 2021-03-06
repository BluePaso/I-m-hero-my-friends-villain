﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class laser : MonoBehaviour {

    private float moveSpeed;

	// Use this for initialization
	void Start () {
        float playerSpeed = GameObject.FindWithTag("Player").GetComponent<PlayerManager>().GetPlayerMoveSpeedX(); // Player의 move speed X 가져옴
        moveSpeed = playerSpeed + 25.0f;

        Destroy(this.gameObject, 2f); //2초 뒤에 자기 자신을 삭제

	}
	
	// Update is called once per frame
	void Update () {

        float moveX = moveSpeed * Time.deltaTime;
        //이동할 거리 지정
        transform.Translate(moveX, 0, 0);
        //이동 반영

	}
}
