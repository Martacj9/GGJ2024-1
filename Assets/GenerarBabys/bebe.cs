using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class bebe : MonoBehaviour
{
    public float speed = 1f;
    public GameObject target;

    public GameObject esteGM;
    public int queGM;

    public int da�o = 20;
    // Start is called before the first frame update
    void Start()
    {
        if(queGM == 1)
        {
            esteGM = GameObject.Find("Game Manager1");
        }
        else if(queGM == 2)
        {
            esteGM = GameObject.Find("Game Manager2");
        }
        //esteGM = ;
        target = esteGM.GetComponent<generarbabyboom>().player;
    }

    // Update is called once per frame
    void Update()
    {
        var step = speed * Time.deltaTime; // calculate distance to move
        transform.position = Vector3.MoveTowards(transform.position, target.transform.position, step);
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            target.GetComponent<jugador>().perderVida(da�o);
            Destroy(this.gameObject);
        }
    }
    public void caramelillo()
    {

    }
}
