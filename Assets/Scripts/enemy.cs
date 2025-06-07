using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{
  public Transform pointA;       // Первая точка патруля
    public Transform pointB;       // Вторая точка патруля
    public float speed = 2f;       // Скорость движения

    private Vector3 targetPosition;

    void Start()
    {
        targetPosition = pointB.position; // Начинаем движение к точке B
    }

    void Update()
    {
        // Двигаемся к цели
        transform.position = Vector3.MoveTowards(transform.position, targetPosition, speed * Time.deltaTime);

        // Если достигли цели — меняем её на другую точку
        if (Vector3.Distance(transform.position, targetPosition) < 0.1f)
        {
            if (targetPosition == pointB.position)
                targetPosition = pointA.position;
            else
                targetPosition = pointB.position;
        }
    }
}
