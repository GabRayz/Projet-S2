﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HUD : MonoBehaviour
{
    public Text Ammo;

    public void ChangeAmmo(int durability)
    {
        Ammo.text = durability.ToString();
    }
    
}