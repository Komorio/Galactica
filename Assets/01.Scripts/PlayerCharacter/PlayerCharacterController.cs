﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class PlayerCharacterController : MonoBehaviour
{
    [Header("Objects")]
    [SerializeField]
    private BallObject redPlanet;

    [SerializeField]
    private BallObject bluePlanet;

    [Header("Values")]
    [SerializeField]
    private float rotateSpeed;

    [SerializeField]
    private int radiusValue;

    private int direction;

    private Ray velocityRay;

    private BallObject mainPlanet;
    private BallObject subPlanet;

    private void Awake(){
        mainPlanet = redPlanet;
        subPlanet = bluePlanet;

        direction = 1;
    }

    private void Start(){
        Vector3 objectPosition = gameObject.transform.position;
        objectPosition.z = Camera.main.gameObject.transform.position.z; 

        Camera.main.gameObject.transform.position = objectPosition;
    }

    private void Update(){
        RotatePlanet();   
        CheckObstacleToRay();

        if(Input.GetKeyDown(KeyCode.A)){
            ChangeObject();
        }
    }

    private void RotatePlanet(){
        float angle = direction * (radiusValue + rotateSpeed);
        subPlanet.gameObject.transform.RotateAround(mainPlanet.gameObject.transform.Position(), Vector3.forward, angle);
    }

    private void ChangeObject(){
        BallObject temp = mainPlanet;

        mainPlanet.Exit();
        
        mainPlanet = subPlanet;
        subPlanet = temp;

        Camera.main.gameObject.transform.DOMoveX(mainPlanet.transform.position.x, 0.5f);
        Camera.main.gameObject.transform.DOMoveY(mainPlanet.transform.position.y, 0.5f);

        mainPlanet.Execute();
    }

    public void ChangeDirection(){
        direction *= -1;
    }

    private float GetPlanetOrbitDirection(){
        float angle = Mathf.Atan2(subPlanet.transform.position.y - mainPlanet.transform.position.y,
        subPlanet.transform.position.x - mainPlanet.transform.position.x) * 180 / Mathf.PI;

        return angle ;
    }

    private void CheckObstacleToRay(){
    float angle = (GetPlanetOrbitDirection() / 180 * Mathf.PI) + (90 * direction);
        float distance = Vector2.Distance(mainPlanet.transform.position, subPlanet.transform.position);
        
        Vector2 newVector;
        
        newVector.x = distance * Mathf.Cos(angle);
        newVector.y = distance * Mathf.Sin(angle);

        newVector = (Vector2)subPlanet.transform.position + newVector;

        velocityRay.origin = subPlanet.transform.position;
        velocityRay.direction = newVector - (Vector2)subPlanet.transform.position;

        RaycastHit2D hit = Physics2D.Raycast(velocityRay.origin, velocityRay.direction, 0.5f, LayerMask.GetMask("Obstacle"));

        if(hit.collider != null){
            ChangeDirection();
        }
    }

    private void OnDrawGizmos() {
        Debug.DrawRay(velocityRay.origin, velocityRay.direction, Color.red);
    }
}
