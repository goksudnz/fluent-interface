// Copyrights(c) Charqe.io. All rights reserved.

using System;
using FluentInterface.interfaces;

namespace FluentInterface
{
    public class Program
    {
        public static void Main(string[] args)
        {
            #region Warrior
            
            var warrior = new Warrior() as ICharacter;
            
            // using dancing skills
            warrior.Dance().DanceLikeTeenager().StopDancingBeCool();
            
            // using weapon skills
            warrior.WearWeapon().Attack().DropWeapon();
            
            // using fluently
            warrior.Dance()
                .DanceLikeWednesday()
                .DanceLikeTeenager()
                .StopDancingBeCool()
                .WearWeapon()
                .Attack()
                .DropWeapon()
                .Run()
                .Rest();
            
            #endregion

            #region Wizard
            
            // it's same for wizard too.
            var wizard = new Wizard() as ICharacter;
            
            // using dancing skills
            wizard.Dance().DanceLikeTeenager().StopDancingBeCool();
            
            // using weapon skills
            wizard.WearWeapon().Attack().DropWeapon();
            
            // using fluently
            wizard.Dance()
                .DanceLikeTeenager()
                .DanceLikeMJ()
                .StopDancingBeCool()
                .WearWeapon()
                .Attack()
                .DropWeapon()
                .Run()
                .Rest();
            
            #endregion

            Console.ReadLine();
        }
    }
}