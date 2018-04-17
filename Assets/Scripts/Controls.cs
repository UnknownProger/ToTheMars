using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controls : MonoBehaviour {

    [Header("Планета")]
    public Transform target;

    [Header("Скорость вращения")]
    public float mouseSensitivity = 10;
    public float touchSensitivity = 0.1f;

    [Header("Дистанция")]
    public float dstFromTarget = 7;

    [Header("Плавность вращения")]
    public float rotationSmoothTime = .12f;


    Vector3 rotationSmoothVelocity;
    Vector3 currentRotation;

    float movX;
    float movY;

    private bool isAllowRotate = true;


    void Rotate()
    {
        if (Input.GetMouseButton(0))
        {
            //Получение позиции по X и по Y
            movX += Input.GetAxis("Mouse X") * mouseSensitivity;
            movY -= Input.GetAxis("Mouse Y") * mouseSensitivity;

            //Получение положения на данный момент
            currentRotation = Vector3.SmoothDamp(currentRotation, new Vector3(movY, movX), ref rotationSmoothVelocity, rotationSmoothTime);
            transform.eulerAngles = currentRotation;

            //Вращение
            transform.position = target.position - transform.forward * dstFromTarget;
        }
            

        if (Input.touchCount > 0)
        {
            movX += Input.touches[0].deltaPosition.x * touchSensitivity;
            movY -= Input.touches[0].deltaPosition.y * touchSensitivity;

            //Получение положения на данный момент
            currentRotation = Vector3.SmoothDamp(currentRotation, new Vector3(movY, movX), ref rotationSmoothVelocity, rotationSmoothTime);
            transform.eulerAngles = currentRotation;

            //Вращение
            transform.position = target.position - transform.forward * dstFromTarget;
        }
    }
	
	// Update is called once per frame
	void Update ()
    {
        if (isAllowRotate)
        {
            Rotate();
        }

        if (Input.GetMouseButtonDown(0))
        {
            //Выпускаем луч от точки нажатия 
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                if (hit.transform.GetComponent<Continent>())
                {


                    //    spawnPosition = hit.transform;

                }
            }
        }
		
	}
}
