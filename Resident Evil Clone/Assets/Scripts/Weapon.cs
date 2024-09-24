using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Weapon : MonoBehaviour
{
    [SerializeField] protected int ammoCapacity;
    [SerializeField] protected int currentLoadedAmmo;
    [SerializeField] protected int currentSpareAmmo;
    [SerializeField] protected bool canFire;
    [SerializeField] protected Transform firePoint;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    }

    protected virtual void Reload()
    {
        if (currentLoadedAmmo < ammoCapacity && currentLoadedAmmo + currentSpareAmmo <= ammoCapacity)
        {
            currentLoadedAmmo += currentSpareAmmo;
            currentSpareAmmo = 0;
        }
        else { 
            currentSpareAmmo -= ammoCapacity - currentLoadedAmmo;
            currentLoadedAmmo = ammoCapacity;
        }
    }

    protected virtual void Fire()
    {
        if (currentLoadedAmmo > 0)
        {
            canFire = true;
        }
        else canFire = false;

        RaycastHit hit;
        if (Physics.Raycast(firePoint.position, firePoint.forward, out hit, 500) && canFire)
        {
            currentLoadedAmmo -= 1;
            if (hit.transform.CompareTag("Zombie"))
            {
                hit.transform.GetComponent<Enemy>().TakeDamage(1);
            }
        }
    }
}
