using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gerenciador : MonoBehaviour
{
    static public gerenciador instancia;
    public movimento mov_jog;
    public bool pausado;
    public GameObject menu_pausa;
    // Start is called before the first frame update

    void Awake(){
        instancia = this;
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            alternarTravamentoDeMouse();
        }
    }

    

    public void alternarTravamentoDeMouse()
    {
        if (!pausado)
        {
            menu_pausa.SetActive(true);
            Cursor.lockState = CursorLockMode.None;
            pausado = !pausado;
            mov_jog.pausado = !mov_jog.pausado;
        }
        else
        {
            menu_pausa.SetActive(false);
            Cursor.lockState = CursorLockMode.Locked;
            pausado = !pausado;
            mov_jog.pausado = !mov_jog.pausado;
        }
    }
}
