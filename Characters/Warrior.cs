// Copyrights(c) Charqe.io. All rights reserved.

using System;
using FluentInterface.interfaces;

namespace FluentInterface
{
    public class Warrior : ICharacter, ICharacterWithWeapon, ICharacterDancing
    {
        #region Just Character Skills
        
        /// <summary>
        /// Using to run character.
        /// </summary>
        /// <returns></returns>
        public ICharacter Run()
        {
            Console.WriteLine("Running like Forest Gump.");
            return this;
        }
        
        /// <summary>
        /// Using to wear weapon. In this case it's an axe!
        /// </summary>
        /// <returns></returns>
        public ICharacterWithWeapon WearWeapon()
        {
            Console.WriteLine("Weapon ware! What a magic axe!");
            return this;
        }
        
        /// <summary>
        /// Using to dance character.
        /// </summary>
        /// <returns></returns>
        public ICharacterDancing Dance()
        {
            Console.WriteLine("Dancing smooth.");
            return this;
        }
        
        /// <summary>
        /// Using to rest character to heal up.
        /// </summary>
        public void Rest()
        {
            Console.WriteLine("Rest in peace.");
            Console.WriteLine("+20 HP");
        }
        
        #endregion

        #region Weapon Skills

        /// <summary>
        /// Using to attack.
        /// </summary>
        /// <returns></returns>
        public ICharacterWithWeapon Attack()
        {
            Console.WriteLine("You're gonna die Charlie!");
            Console.WriteLine("Attacked!");
            return this;
        }

        /// <summary>
        /// Using to drop weapon from character.
        /// </summary>
        /// <returns></returns>
        public ICharacter DropWeapon()
        {
            Console.WriteLine("That's enough! Peace at home, peace in the world!");
            Console.WriteLine("Weapon dropped.");
            return this;
        }
        #endregion

        #region Dancing Skills
        
        /// <summary>
        /// Using to dance like Wednesday Addams.
        /// </summary>
        /// <returns></returns>
        public ICharacterDancing DanceLikeWednesday()
        {
            Console.WriteLine("Dancing like no emotion.");
            return this;
        }

        /// <summary>
        /// Using to dance like Michael Jackson.
        /// </summary>
        /// <returns></returns>
        public ICharacterDancing DanceLikeMJ()
        {
            Console.WriteLine("Anny are you OK?");
            return this;
        }

        /// <summary>
        /// Using to dance like teenager.
        /// </summary>
        /// <returns></returns>
        public ICharacterDancing DanceLikeTeenager()
        {
            Console.WriteLine("What you gonna do do do do do.");
            return this;
        }

        /// <summary>
        /// Using to stop dancing.
        /// </summary>
        /// <returns></returns>
        public ICharacter StopDancingBeCool()
        {
            Console.WriteLine("Hey! I'm hero. What the hell am i doing here in dance floor??!");
            return this;
        }
        
        #endregion

    }
}