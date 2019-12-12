using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class movimento : NetworkBehaviour
{
    public bool vivo = true, pausado = false, cursor_travado = true;
    public float velocidade = 5, sensi_velocidade = 5, sens_rot = 30, angulo_visao_y;

    public float velx, velesq, veldir, velz, velfre, veltra;

    public GameObject player_pivot, bullet, bullet_cannon;

    public Quaternion rotacao;
    // Start is called before the first frame update
    void Start()
    {
        gerenciador.instancia.mov_jog = this;
        
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        // controle

        if (vivo)
        {
            if (!pausado)
            {

                if (Input.GetKey(KeyCode.A))
                {
                    velesq -= Time.deltaTime * sensi_velocidade;
                }
                else
                {
                    velesq += Time.deltaTime * sensi_velocidade;
                }

                velesq = Mathf.Clamp(velesq, -1, 0);

                if (Input.GetKey(KeyCode.D))
                {
                    veldir += Time.deltaTime * sensi_velocidade;
                }
                else
                {
                    veldir -= Time.deltaTime * sensi_velocidade;
                }

                veldir = Mathf.Clamp(veldir, 0, 1);



                if (Input.GetKey(KeyCode.S))
                {
                    veltra -= Time.deltaTime * sensi_velocidade;
                }
                else
                {
                    veltra += Time.deltaTime * sensi_velocidade;
                }

                veltra = Mathf.Clamp(veltra, -1, 0);

                if (Input.GetKey(KeyCode.W))
                {
                    velfre += Time.deltaTime * sensi_velocidade;
                }
                else
                {
                    velfre -= Time.deltaTime * sensi_velocidade;
                }

                velfre = Mathf.Clamp(velfre, 0, 1);



                velx = velesq + veldir;
                velz = velfre + veltra;

                transform.Translate(velx * velocidade * Time.deltaTime, 0, velz * velocidade * Time.deltaTime);

                angulo_visao_y = Input.GetAxis("Mouse X");

                player_pivot.transform.Rotate(0,angulo_visao_y * Time.deltaTime * sens_rot,0);

            }
        }


        

    }
}
