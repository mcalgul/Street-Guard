using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunController : MonoBehaviour
{
    public bool atesEdebilirmi;
    float �ceridenAtesEtmeSikligi;
    public float disaridanAtesEtmeSikligi;
    public float menzil;
    public Camera benimCam;
    public AudioSource AtesSesi;
    public ParticleSystem AtesEfekt;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.Mouse0) && atesEdebilirmi && Time.time > �ceridenAtesEtmeSikligi)
        {
            AtesEt();
            �ceridenAtesEtmeSikligi = Time.time + disaridanAtesEtmeSikligi;


        }

    }

    void AtesEt()
    {

        AtesSesi.Play();
        AtesEfekt.Play();

        RaycastHit hit;
        //Cameran�n bak�� a��s�ndan ileriye do�ru bir ���n g�nderir. I��n�n de�di�i yeri debuga yazd�r�r.
        if (Physics.Raycast(benimCam.transform.position, benimCam.transform.forward, out hit, menzil))
        {

            Debug.Log(hit.transform.name);

        }

    }
}
