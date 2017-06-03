using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpen : MonoBehaviour
{
    public GameObject door1, door2, door3, door4, door5, door6;

    void Update()
    {
        StartCoroutine(open());
    }

    IEnumerator open()
    {
        if (Reticule.openDoor1 == true)
        {
            for (int i = 0; i < 5; i++)
            {
                door1.transform.position += new Vector3(0, 0, 1);
                yield return new WaitForEndOfFrame();
                Reticule.openDoor1 = false;

                for (int e = 0; e < 1; e++)
                {
                    door2.transform.position += new Vector3(0, 0, -1);
                    yield return new WaitForEndOfFrame();
                    Reticule.openDoor1 = false;
                }
            }

        }

        if (Reticule.openDoor2 == true)
        {
            for (int i = 0; i < 5; i++)
            {
                door3.transform.position += new Vector3(-1, 0, 0);
                yield return new WaitForEndOfFrame();
                Reticule.openDoor2 = false;

                for (int e = 0; e < 1; e++)
                {
                    door4.transform.position += new Vector3(1, 0, 0);
                    yield return new WaitForEndOfFrame();
                    Reticule.openDoor2 = false;
                }
            }

        }

        if (Reticule.openDoor3 == true)
        {
            for (int i = 0; i < 5; i++)
            {
                door5.transform.position += new Vector3(0, 0, 1);
                yield return new WaitForEndOfFrame();
                Reticule.openDoor3 = false;

                for (int e = 0; e < 1; e++)
                {
                    door6.transform.position += new Vector3(0, 0, -1);
                    yield return new WaitForEndOfFrame();
                    Reticule.openDoor3 = false;
                }
            }

        }
    }
}
