﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThunderRoad;
using UnityEngine;

namespace PlanetaryDevastation
{
    class PlanetModule : ItemModule
    {

        public override void OnItemLoaded(Item item)
        {
            base.OnItemLoaded(item);

            item.gameObject.AddComponent<Planet>();
           
        }

    }
}
