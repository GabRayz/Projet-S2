﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Uprising.Items;
using Uprising.Players;

public class CollectibleController : MonoBehaviour {

    //private Collectible item;
    private Vector3 rotation;
    public ItemType type;
    public Item item = null;
    GameObject spot = null;
    public GameObject model;
    public Rigidbody modelRB;

    // Use this for initialization
    void Start () {
        modelRB = model.GetComponent<Rigidbody>();
        switch (type)
        {

            case ItemType.SpeedBoost:
                this.item = new SpeedBoost(5000, null);
                break;
            case ItemType.DefaultGun:
                this.item = new DefaultGun(100, 60, 20, 20, null);
                break;
            case ItemType.ShotGun:
                this.item = new ShotGun(10, 7, 70, 95, null);
                break;
            case ItemType.Minigun:
                this.item = new Minigun(100, 50, 5, 5, null);
                break;
            case ItemType.Sniper:
                this.item = new Sniper(30, 200, 60, 95, null);
                break;
            case ItemType.Invisibility:
                this.item = new Invisibility(10000, null);
                break;
            case ItemType.Dash:
                this.item = new Dash(5, null);
                break;
            case ItemType.JumpBoost:
                this.item = new JumpBoost(4000, null);
                break;
            case ItemType.BearTrap:
                this.item = new BearTrap(null);
                break;
            case ItemType.ForceField:
                this.item = new ForceField(15000, null);
                break;
            case ItemType.Mine:
                this.item = new Mine(0, null);
                break;
            case ItemType.Grapnel:
                this.item = new Grapnel(2, null);
                break;
            case ItemType.RocketLauncher:
                this.item = new RocketLauncher(1, null);
                break;
            case ItemType.Rifle:
                this.item = new Rifle(50, 120, 35, 50, null);
                break;
            case ItemType.AssaultRifle:
                this.item = new AssaultRifle(50, 100, 15, 40, null);
                break;
            case ItemType.MachineGun:
                this.item = new MachineGun(75, 60, 10, 7, null);
                break;
            case ItemType.Drugs:
                this.item = new Drugs(10000, null);
                break;
            case ItemType.Shield:
                this.item = new Shield(200, null);
                break;
            case ItemType.GuidedMissile:
                this.item = new GuidedMissile(1, null);
                break;
            default:
                Debug.LogError("This item type is not related to a class");
                break;
        }

        if(!(item is Effect))
        {
            rotation = new Vector3(0, 60, 0);
        }
        else
        {
            rotation = new Vector3(60, 60, 60);
        }
    }

    private void FixedUpdate()
    {
        Quaternion deltaRot = Quaternion.Euler(rotation * Time.deltaTime);
        modelRB.MoveRotation(modelRB.rotation * deltaRot);
    }

    public void Collect(GameObject player)
    {
        gameObject.SetActive(false);

        if (item != null)
        {
            if (spot != null)
            {
                spot.SendMessage("PickUp");
            }
            player.SendMessage("GiveItem", this.item);
            Destroy(this.gameObject);
        }
        else
        {
            Debug.LogError("Item is not defined for this CollectibleController");
        }
    }

    public void SetSpot(GameObject spot)
    {
        this.spot = spot;
    }
}
