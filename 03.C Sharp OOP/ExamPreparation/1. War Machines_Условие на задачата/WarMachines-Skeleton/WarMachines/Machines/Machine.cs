namespace WarMachines.Machines
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using WarMachines.Commons;
    using WarMachines.Interfaces;

    public abstract class Machine : IMachine
    {
        private string name;
        private IPilot pilot;
        private IList<string> targets;

        protected Machine(string name, double attackPoints, double defensePoints, double healthPoints)
        {
            this.Name = name;
            this.AttackPoints = attackPoints;
            this.DefensePoints = defensePoints;
            this.HealthPoints = healthPoints;
            this.targets = new List<string>();
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                Validator.CheckIfStringIsNullOrEmpty(value, "Machine name cannot be null");
                this.name = value;
            }
        }

        public IPilot Pilot
        {
            get
            {
                return this.pilot;
            }
            set
            {
                Validator.CheckIfNull(value, "Pilot cannot be null");
                this.pilot = value;
            }
        }

        public double HealthPoints { get; set; }

        public double AttackPoints { get; protected set; }

        public double DefensePoints { get; protected set; }

        public IList<string> Targets
        {
            get { return new List<string>(this.targets); }
        }

        public void Attack(string target)
        {
            Validator.CheckIfStringIsNullOrEmpty(target);
            this.targets.Add(target);
        }

        public override string ToString()
        {
            var restult = new StringBuilder();

            var targetsAsString = this.targets.Count > 0
                ? string.Join(", ", this.targets)
                : "None";

            restult.AppendLine(string.Format("- {0}", this.Name));
            restult.AppendLine(string.Format(" *Type: {0}", this.GetType().Name));
            restult.AppendLine(string.Format(" *Health: {0}", this.HealthPoints));
            restult.AppendLine(string.Format(" *Attack: {0}", this.AttackPoints));
            restult.AppendLine(string.Format(" *Defense: {0}", this.DefensePoints));
            restult.AppendLine(string.Format(" *Targets: {0}", targetsAsString));

            return restult.ToString();
        }
    }
}
