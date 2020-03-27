﻿using System;
using ViceCity.Models.Guns.Contracts;

namespace ViceCity.Models.Guns
{
    public abstract class Gun : IGun
    {
        private string name;
        private int bulletsPerBarrel;
        private int totalBullets;

        public Gun(string name, int bulletsPerBarrel, int totalBullets)
        {
            this.Name = name;
            this.BulletsPerBarrel = bulletsPerBarrel;
            this.TotalBullets = totalBullets;
        }

        public string Name
        {
            get => this.name;
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Name cannot be null or a white space!");

                this.name = value;
            }

        }
        public int BulletsPerBarrel
        {
            get => this.bulletsPerBarrel;
            protected set
            {
                if (value < 0)
                    throw new ArgumentException("Bullets cannot be below zero!");

                this.bulletsPerBarrel = value;
            }

        }
        public int TotalBullets
        {
            get => this.totalBullets;
            private set
            {
                if (this.totalBullets < 0)
                    throw new ArgumentException("Total bullets cannot be below zero!");

                this.totalBullets = value;
            }
        }
        public bool CanFire => this.TotalBullets > 0;

        //TODO check Fire to be an abstract or virtual 
        public abstract int Fire();
        
        protected void Reload()
        {
            this.TotalBullets -= this.BulletsPerBarrel;
        }
        
    }
}
