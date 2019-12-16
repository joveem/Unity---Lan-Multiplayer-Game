using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    public float speed = 20, duration = 5;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(waitForDestroy());
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }

    IEnumerator waitForDestroy(){
        yield return new WaitForSeconds(duration);

        Destroy(gameObject);
    }
}
