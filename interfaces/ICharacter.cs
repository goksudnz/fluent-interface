// Copyrights(c) Charqe.io. All rights reserved.

namespace FluentInterface.interfaces
{
    public interface ICharacter
    {
        ICharacterWithWeapon WearWeapon();
        ICharacter Run();
        ICharacterDancing Dance();
        void Rest();
        
    }
}