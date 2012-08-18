﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SpoutAPI.Tick;
using SpoutAPI.Entity.Components;

namespace SpoutAPI.Entity
{
    public interface Entity : Tickable
    {
        /// <summary>
        /// Id for the entity inside the manager.  This is not saved.  
        /// </summary>
        int Id
        {
            get;
        }

        /// <summary>
        /// Persistant ID for the entity.  This is saved
        /// </summary>
        Guid Guid
        {
            get;
        }
        /// <summary>
        /// Location of the Entity in space.
        /// Never null.  
        /// </summary>
        Transform Transform
        {
            get;
        }
        /// <summary>
        /// Controller Component for the entity.  May be null
        /// </summary>
        Controller Controller
        {
            get;
            set;
        }
       
        /// <summary>
        /// View distance of the entity
        /// Only is check if the entity is an observer
        /// </summary>
        int ViewDistance
        {
            get;
            set;
        }
        /// <summary>
        /// True if the entity can see and load chunks, false if it cannot
        /// </summary>
        bool Observer
        {
            get;
            set;
        }
        /// <summary>
        /// True if the entity is alive and simulating
        /// </summary>
        bool Spawned
        {
            get;
        }

        /// <summary>
        /// True if the entity is dead and not being simulated
        /// </summary>
        bool Dead
        {
            get;
        }

        /// <summary>
        /// Called when the entity is synced to clients
        /// </summary>
        void OnSync();

        /// <summary>
        /// Called at the end of the tick stage
        /// </summary>
        void FinializeTick();

        /// <summary>
        /// Kills an entity.  This takes effect in the next snapshot stage
        /// </summary>
        /// <returns></returns>
        bool Kill();


    }
}