﻿using System;
using UnityEngine;

namespace Uprising.Item
{
    public class SpeedBoost : Effect
    {
        public SpeedBoost(int time, GameObject player)
        {
            this.type = ItemType.SpeedBoost;
            // time is in millisecond
            this.durability = time;
            this.player = player;
        }
    }
}
