using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pistol : Weapon
{
    public static Pistol instance;

    // Start is called before the first frame update
    private void Awake()
    {
        instance = this;
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Fire();
        }
        if (Input.GetMouseButtonDown(1))
        {
            Reload();
        }
    }

    protected override void Fire()
    {
        base.Fire();
    }

    protected override void Reload()
    {
        base.Reload();
    }
}
