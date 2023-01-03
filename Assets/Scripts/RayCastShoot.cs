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

                string hitName = hit.collider.transform.parent.gameObject.name;
                GameObject hitObject = hit.collider.transform.parent.gameObject;

                if(hitName == "Alien" || hitName == "secondAlien Variant"){
                    Shootable shootableObject = hitObject.GetComponent<Shootable>();
                    if(shootableObject != null){
                        shootableObject.Damage(gunDamage);
                    }
                }
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
