// Copyrights(c) Charqe.io. All rights reserved.

using System;
using FluentInterface.interfaces;

namespace FluentInterface
{
    public class Wizard : ICharacter, ICharacterWithWeapon, ICharacterDancing
    {
        #region Just Character Skills
        
        public ICharacterWithWeapon WearWeapon()
        {
            Console.WriteLine("Ware wand!");
            return this;
        }

        public ICharacter Run()
        {
            Console.WriteLine("Gliding...");
            return this;
        }

        public ICharacterDancing Dance()
        {
            Console.WriteLine("Dancing on the floor.");
            return this;
        }

        public void Rest()
        {
            Console.WriteLine("You are in Hogwarts. Rest.");
        }
        
        #endregion

        #region Weapon Skills
        
        public ICharacterWithWeapon Attack()
        {
            Console.WriteLine("Expecto Patronum!");
            return this;
        }

        public ICharacter DropWeapon()
        {
            Console.WriteLine("Oops.");
            return this;
        }
        
        #endregion

        #region Dancing Skills
        
        public ICharacterDancing DanceLikeWednesday()
        {
            Console.WriteLine("Dancing like Wednesday Addams.");
            return this;
        }

        public ICharacterDancing DanceLikeMJ()
        {
            Console.WriteLine("Dancing like Michael Jackson.");
            return this;
        }

        public ICharacterDancing DanceLikeTeenager()
        {
            Console.WriteLine("Dancing like teenager");
            return this;
        }

        public ICharacter StopDancingBeCool()
        {
            Console.WriteLine("Stop dancing.");
            return this;
        }
        
        #endregion
    }
}