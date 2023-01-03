using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayCastShoot : MonoBehaviour{
    
    public int gunDamage = 1;
    public float fireRate = .24f;
    public float weaponRange = 50;
    public float hitForce = 100;
    public Transform gunEnd;
    public AudioSource gunAudio;
    public Camera fpsCam;

    private WaitForSeconds shotDuration = new WaitForSeconds(.07f);
    private LineRenderer laserLine;
    private float nextFire;

    void Start(){
        laserLine = GetComponent<LineRenderer>();
    }

    void Update(){
        if(Input.GetButtonDown("Fire1") && Time.time > nextFire){
            nextFire = Time.time + fireRate;
            StartCoroutine(ShotEffect());
            Vector3 rayOrigin = fpsCam.ViewportToWorldPoint(new Vector3(0.5f, 0.5f, 0));

            RaycastHit hit;

            laserLine.SetPosition(0, gunEnd.position);

            if(Physics.Raycast(rayOrigin, fpsCam.transform.forward, out hit, weaponRange)){
                laserLine.SetPosition(1, hit.point);

                // Shootable health = hit.collider.GetComponent<Shootable>();
                string hitName = hit.collider.transform.parent.gameObject.name;
                Debug.Log("hitName");
                Debug.Log(hitName);
                GameObject hitObject = hit.collider.transform.parent.gameObject;
                Debug.Log("herer-----------------");
                // Debug.Log(hit);
                Debug.Log(hit.collider.transform.parent.gameObject);
                Debug.Log("herer-----------------");

                if(hitName == "Alien" || hitName == "secondAlien Variant"){
                    Debug.Log("-------------*******************************");
                    Debug.Log(hitObject);
                    Shootable test = hitObject.GetComponent<Shootable>();
                    if(test != null){
                        Debug.Log("test");
                        Debug.Log(test);
                        test.Damage(gunDamage);
                    }
                    // hitObject.Damage(gunDamage);
                }
                // if(health != null){
                //     health.Damage(gunDamage);
                // }

                // Debug.Log("hit.rigidbody");
                // Debug.Log(hit.rigidbody);
                if(hit.rigidbody != null){
                    hit.rigidbody.AddForce(-hit.normal * hitForce);
                }
            }else{
                laserLine.SetPosition(1, rayOrigin + (fpsCam.transform.forward * weaponRange));
            }
        }
    }

    private IEnumerator ShotEffect(){
        gunAudio.Play();

        laserLine.enabled = true;
        yield return shotDuration;
        laserLine.enabled = false;
    }
}
