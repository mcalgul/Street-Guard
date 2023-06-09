using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunController : MonoBehaviour
{
    public bool atesEdebilirmi;
    float İceridenAtesEtmeSikligi;
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

        if (Input.GetKey(KeyCode.Mouse0) && atesEdebilirmi && Time.time > İceridenAtesEtmeSikligi)
        {
            AtesEt();
            İceridenAtesEtmeSikligi = Time.time + disaridanAtesEtmeSikligi;


        }

    }

    void AtesEt()
    {

        AtesSesi.Play();
        AtesEfekt.Play();

        RaycastHit hit;
        //Cameranın bakış açısından ileriye doğru bir ışın gönderir. Işının değdiği yeri debuga yazdırır.
        if (Physics.Raycast(benimCam.transform.position, benimCam.transform.forward, out hit, menzil))
        {

            Debug.Log(hit.transform.name);

        }

    }
}
