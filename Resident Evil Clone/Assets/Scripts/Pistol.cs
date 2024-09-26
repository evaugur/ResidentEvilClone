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
    }

    public override void Fire()
    {
        base.Fire();
    }

    public override void Reload(Magazine newMag)
    {
        base.Reload(newMag);
    }
}
