using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Transcendence.BuisnessLogic.Models.Character
{
    public interface IActionDirector
    {

        void PerformAction(IBasicCharacter performer, ICharacterAction action, IBasicCharacter target);

    }
}
