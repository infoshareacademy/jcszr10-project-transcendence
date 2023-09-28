
using Project_Transcendence.BuisnessLogic.Models.Character.Enemy;
using Project_Transcendence.BuisnessLogic.Models.DTOs;

namespace Project_Transcendence.BuisnessLogic.Models.Builders
{
    public class EnemyCharacterBuilder : IEnemyCharacterBuilder
    {
        private readonly EnemyDto _enemyDto;
        private readonly Enemy _enemy;

        public EnemyCharacterBuilder(EnemyDto dto)
        {
            _enemyDto = dto;
        }


        public Enemy Build()
        {
            return _enemy;
        }

        public void SetAbilities()
        {
            throw new NotImplementedException();
        }

        public void SetId()
        {
            _enemy.Id = _enemyDto.Id;
        }

        public void SetInventory()
        {
            throw new NotImplementedException();
        }

        public void SetLevel()
        {
            _enemy.Level = _enemyDto.Level;
        }

        public void SetName()
        {
            _enemy.Name = _enemyDto.Name;
        }

        public void SetRace()
        {
            throw new NotImplementedException();
        }
    }
}
