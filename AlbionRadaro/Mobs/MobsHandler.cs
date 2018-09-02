﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlbionRadaro.Mobs
{
    class MobsHandler
    {
        private List<Mob> mobsList;

        public MobsHandler()
        {
            mobsList = new List<Mob>();
        }

        public void AddMob(int id, int typeId, Single posX, Single posY, int health)
        {
            Mob h = new Mob(id, typeId, posX, posY, health);
            if (!mobsList.Contains(h)) {
                mobsList.Add(h);
                Console.WriteLine("Add mob: " + h.ToString());
            }
        }
        public bool RemoveMob(int id)
        {
            return mobsList.RemoveAll(x => x.Id == id) > 0;
        }

        internal List<Mob> MobList
        {
            get { return mobsList; }
        }


        internal void UpdateMob(int mobId, byte health)
        {
            mobsList.ForEach(h =>
            {
                if (h.Id == mobId)
                {
                    //TODO - update 
                    h.Health = health;
                }
            });

        }
    }
}