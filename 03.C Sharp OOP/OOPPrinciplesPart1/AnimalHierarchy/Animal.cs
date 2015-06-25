namespace AnimalHierarchy
{
    using System;

    public abstract class Animal : ISound
    {
        private byte age;
        private string name;

        protected Animal(string name, byte age, Gender sex)
        {
            this.Sex = sex;
            this.Name = name;
            this.Age = age;
        }

        public Gender Sex { get; private set; }

        public string Name
        {
            get
            {
                return this.name;
            }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Name can not be empty.");
                }

                this.name = value;
            }
        }

        public byte Age
        {
            get
            {
                return this.age;
            }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Age can not be less than 0.");
                }

                this.age = value;
            }
        }

        public abstract void ProduceSound();

        public override string ToString()
        {
            return string.Format("Animal: {0}\nName: {1}\nGender: {2}\nAge: {3}",
                this.GetType().Name, this.Name, this.Sex, this.Age);
        }
    }
}
