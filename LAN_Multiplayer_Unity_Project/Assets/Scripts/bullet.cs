using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class bullet : NetworkBehaviour
{
    public float speed = 20, duration = 5, damage = 10;
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

    IEnumerator waitForDestroy()
    {
        yield return new WaitForSeconds(duration);

        CmdDestroy(gameObject);
    }


    [Command]
    void CmdDestroy(GameObject obj_)
    {
        NetworkServer.Destroy(obj_);
    }


    private void OnTriggerEnter(Collider other_) {
        if(other_.tag == "Player"){
            other_.GetComponent<player>().health -= damage;
        }
    }
}
