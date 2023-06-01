using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slide : MonoBehaviour
{
    [SerializeField] private float speed = 3;

    public void SlideUp()
    {
        transform.position += new Vector3(0,100,0);

    }

    IEnumerator waitFinished()
    {
        yield return new WaitForSeconds(60);
    }
}
