using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameEngine : MonoBehaviour
{
    [SerializeField] private GameObject myShip;


    [SerializeField] private Vector3 clickedPosition;

    [SerializeField] private bool isClicked;

    void Start()
    {
        isClicked = false;
    }
    
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            // Creates a Ray from the mouse position
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            isClicked = true;

            if (Physics.Raycast(ray, out hit))
            {
                clickedPosition = hit.transform.position;
                print("Myship" + myShip.transform.position);
                print("Clicked" + clickedPosition);
            }
        }

        if (isClicked)
        {
            myShip.transform.position = Vector3.MoveTowards(myShip.transform.position, clickedPosition, 3f * Time.deltaTime);
            myShip.transform.LookAt(clickedPosition);
        }
    }
}
