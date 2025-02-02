﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Uprising.Players;

namespace Uprising.Items
{
    public class AssaultRifle : Weapon
    {
        public AssaultRifle(int durability, float accuracy, float firerate, float knockback, GameObject player)
        {
            this.type = ItemType.AssaultRifle;
            this.durability = durability;
            this.accuracy = accuracy;
            this.firerate = firerate;
            this.knockback = knockback;
            this.player = player;

            fireratetime = firerate;
        }

        public override void Aim()
        {
            Debug.Log("Aimed.");

        }

        //public override void Use()
        //{
        //    if (fireratetime >= firerate)
        //    {
        //        player.GetComponent<PlayerControl>().hand.transform.Find("h_AssaultRifle").GetComponent<belettegen>().shoot(durability, this.target.transform.forward, this);
        //        if (player.GetComponent<PlayerControl>().playerStats != null)
        //            player.GetComponent<PlayerControl>().playerStats.belettesShot += 1;
        //        fireratetime = 0;
        //        durability--;
        //    }
        //    if (durability < 0)
        //    {
        //        player.SendMessage("ClearItem", this as Item);
        //    }
        //}
    }
}