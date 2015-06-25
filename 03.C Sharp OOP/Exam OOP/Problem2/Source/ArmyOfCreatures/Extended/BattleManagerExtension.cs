namespace ArmyOfCreatures.Extended
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;

    using ArmyOfCreatures.Logic.Battles;
    using ArmyOfCreatures.Logic;

    public class BattleManagerExtension : BattleManager
    {
        private readonly ICollection<ICreaturesInBattle> thirdArmyCreatues;

        public BattleManagerExtension(ICreaturesFactory creaturesFactory, ILogger logger)
            : base(creaturesFactory, logger)
        {
            this.thirdArmyCreatues = new List<ICreaturesInBattle>();
        }

        protected override void AddCreaturesByIdentifier(CreatureIdentifier creatureIdentifier, ICreaturesInBattle creaturesInBattle)
        {
            if (creatureIdentifier.ArmyNumber == 3)
            {
                this.thirdArmyCreatues.Add(creaturesInBattle);
            }

            base.AddCreaturesByIdentifier(creatureIdentifier, creaturesInBattle);
        }

        protected override ICreaturesInBattle GetByIdentifier(CreatureIdentifier identifier)
        {
            if (identifier.ArmyNumber == 3)
            {
                return this.thirdArmyCreatues.FirstOrDefault(x => x.Creature.GetType().Name == identifier.CreatureType);
            }

            return base.GetByIdentifier(identifier);
        }
    }
}
