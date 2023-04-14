using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunController : MonoBehaviour
{
    public bool atesEdebilirmi;
    float ÝceridenAtesEtmeSikligi;
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

        if (Input.GetKey(KeyCode.Mouse0) && atesEdebilirmi && Time.time > ÝceridenAtesEtmeSikligi)
        {
            AtesEt();
            ÝceridenAtesEtmeSikligi = Time.time + disaridanAtesEtmeSikligi;


        }

    }

    void AtesEt()
    {

        AtesSesi.Play();
        AtesEfekt.Play();

        RaycastHit hit;
        //Cameranýn bakýþ açýsýndan ileriye doðru bir ýþýn gönderir. Iþýnýn deðdiði yeri debuga yazdýrýr.
        if (Physics.Raycast(benimCam.transform.position, benimCam.transform.forward, out hit, menzil))
        {

            Debug.Log(hit.transform.name);

        }

    }
}
