using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class game_manager : MonoBehaviour
{
    static public game_manager instancia;
    public movement mov_jog;
    public bool pausado;
    public GameObject menu_pausa;
    // Start is called before the first frame update

    void Awake()
    {
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

        if (pausado)
        {
            menu_pausa.SetActive(true);
            Cursor.lockState = CursorLockMode.None;
            
            if(mov_jog != null){
                mov_jog.pausado = false;
            }
        }
        else
        {
            menu_pausa.SetActive(false);
            Cursor.lockState = CursorLockMode.Locked;
            
            if(mov_jog != null){
                mov_jog.pausado = false;
            }
            
        }
    }



    public void alternarTravamentoDeMouse()
    {
        pausado = !pausado;
    }
}
