using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Reticule : MonoBehaviour
{

    public static bool openDoor1, openDoor2, openDoor3;
    public GameObject arm, pillGood, pillBad;
    public Vector2 mousePos;
    public float rayRange = 8;
    public Animator animator;


    void Start()
    {
    }

    void Update()
    {
        mousePos = Input.mousePosition;
        RaycastToMouse();
        if (pillGood == null)
        {
            arm.SetActive(false);
        }
    }
    void RaycastToMouse()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        RaycastHit hit;


        if (Input.GetKeyDown(KeyCode.E) && Physics.Raycast(ray, out hit, rayRange))
        {

            if (hit.collider.gameObject.tag == "GoodPills")
            {
                arm.SetActive(true);

                animator.SetTrigger("Activate");
                //SceneManager.LoadScene(2);
                Destroy(pillGood, 1.2f);

            }

            if (hit.collider.gameObject.tag == "BadPills")
            {
                Destroy(hit.transform.gameObject);
            }

            if (hit.collider.gameObject.tag == "Door1")
            {
                openDoor1 = true;
            }

            if (hit.collider.gameObject.tag == "Door2")
            {
                openDoor2 = true;
            }

            if (hit.collider.gameObject.tag == "Door3")
            {
                openDoor3 = true;
            }
        }
    }

    void OnGUI()
    {
        GUI.Box(new Rect(mousePos.x, mousePos.y, 1, 1), "eh");
    }
}
