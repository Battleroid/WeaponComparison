using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeaponComparison
{
    class Weapon
    {
        // base
        public string name { get; private set; }
        public WeaponClass type { get; private set; }

        // base integer stats
        public int rpm { get; private set; }
        public int velocity { get; private set; }
        public int distance { get; private set; }
        public double drop { get; private set; }
        public int magazineSize { get; private set; }

        // detailed stats
        public double reloadTime { get; private set; }
        public double fullReloadTime { get; private set; }
        public int recoilDecrease { get; private set; }
        public double firstShotMultiplier { get; private set; }
        public double recoilLeft { get; private set; }
        public double recoilUp { get; private set; }
        public double recoilRight { get; private set; }
        
        // damage
        public double maxDamage { get; private set; }
        public double minDamage { get; private set; }
        public double dropStart { get; private set; }
        public double dropEnd { get; private set; }

        // chart data
        public double[] pointsX { get; private set; }
        public double[] pointsY { get; private set; }
        public double[][] pointsXY { get; private set; }

        public Weapon(string name, WeaponClass type, int rpm, int velocity, int distance, double drop, int magazineSize, double reloadTime, double fullReloadTime, int recoilDecrease, double firstShotMultiplier, double recoilLeft, double recoilUp, double recoilRight, double maxDamage, double minDamage, double dropStart, double dropEnd) {
            this.name = name;
            this.type = type;
            this.rpm = rpm;
            this.velocity = velocity;
            this.distance = distance;
            this.drop = drop;
            this.magazineSize = magazineSize;
            this.reloadTime = reloadTime;
            this.fullReloadTime = fullReloadTime;
            this.recoilDecrease = recoilDecrease;
            this.firstShotMultiplier = firstShotMultiplier;
            this.recoilLeft = recoilLeft;
            this.recoilUp = recoilUp;
            this.recoilRight = recoilRight;
            this.maxDamage = maxDamage;
            this.minDamage = minDamage;
            this.dropStart = dropStart;
            this.dropEnd = dropEnd;

            this.pointsX = new double[] { 0, dropStart, dropEnd, 100 };
            this.pointsY = new double[] { maxDamage, maxDamage, minDamage, minDamage };
            this.pointsXY = new double[][] {
                this.pointsX,
                this.pointsY
            };
        }

        public string[] dumpAttributes() {
            // dump attributes (with descriptions) for use in the listboxes
            return new string[] {
                this.type.ToString() + " type weapon",
                this.rpm.ToString() + " RPM",
                this.velocity.ToString() + " m/s muzzle velocity",
                this.distance.ToString() + " meters maximum effective distance",
                this.drop.ToString() + " m/s^2 bullet drop",
                this.magazineSize.ToString() + " rounds in magazine",
                this.reloadTime.ToString() + " reload time in secs (round chambered)",
                this.fullReloadTime.ToString() + " reload time in secs (no round chambered)",
                this.recoilDecrease.ToString() + " recoil decrease per second",
                this.firstShotMultiplier.ToString() + " first shot multiplier (recoil)",
                this.recoilLeft.ToString() + " left hand recoil pull",
                this.recoilRight.ToString() + " right hand recoil pull",
                this.recoilUp.ToString() + " upward recoil pull",
                this.maxDamage + " maximum damage per bullet until " + this.dropStart + " meters",
                this.minDamage + " minimum damage damage after " + this.dropEnd + " meters"
            };
        }

        public override string ToString() {
            return this.name;
        }
    }
}
