using System;
using System.Collections.Generic;
using System.Text;

namespace TheCoffeMechine
{
    class CoffeMechine
    {
        private CoffePowder coffePowder;
        private WaterGalon waterGalon;
        private Milk Milk;

        public CoffeMechine(CoffePowder powder, WaterGalon galon, Milk milk)
        {
            this.waterGalon = galon;
            this.coffePowder = powder;
            this.Milk = milk;
        }

        public String makeEsspresso()
        {
            if (!this.waterGalon.isAvailable())
            {
                return "Sorry, the water is empty";
            }
            if (!this.coffePowder.isAvailable())
            {
                return "Sorry, the coffe is empty";
            }

            this.waterGalon.makeOneCup();
            this.coffePowder.makeOneCup();
            return "Yey! your Esspreso coffe is ready";
        }

        public String makeCappucino()
        {
            if (!this.waterGalon.isAvailable())
            {
                return "Sorry, the water is empty";
            }
            if (!this.coffePowder.isAvailable())
            {
                return "Sorry, the coffe is empty";
            }
            if (!this.coffePowder.isAvailable())
            {
                return "Sorry, the milk is empty";
            }

            this.waterGalon.makeOneCup();
            this.coffePowder.makeOneCup();
            this.Milk.makeOneCup();
            return "Yey! your Cappucino coffe is ready";
        }

        public String checkAvailability()
        {
            return $"the water :{this.waterGalon.getVolume()} , the coffe powder: { this.coffePowder.getNetto()}, and the milk : {this.Milk.getVolume()}";
        }
    }
}
