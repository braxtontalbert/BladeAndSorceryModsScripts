﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using ThunderRoad;

namespace WandSpellss
{
    public class AvadaKedavra : MonoBehaviour
    {
        Item item;
        internal ItemData avadaLightning;
        internal AudioSource source;
        Item lightningItem;
        public Creature hitCreatures;
        public void Start()
        {
            item = GetComponent<Item>();
            
        }


        public void OnCollisionEnter(Collision c)
        {
            c.gameObject.GetComponentInParent<Creature>().Kill();
            
        }


        


    }

}
