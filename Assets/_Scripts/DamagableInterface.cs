﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamagableInterface : MonoBehaviour
{
    public interface IDamagable
    {
        void TakeDamage(float dmg);
        void CheckHealth();
        void ApplyPushForce(Vector3 force);
    }
}
