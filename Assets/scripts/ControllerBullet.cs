﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ControllerBullet
{
    public abstract void Shoot(Transform muzzle);
    public virtual void Destroy()
    {
        new ServiceBullet().RemoveBullet(this);
    }

}
