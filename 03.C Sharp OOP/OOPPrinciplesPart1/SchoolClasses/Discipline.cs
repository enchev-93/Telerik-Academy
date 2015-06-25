﻿namespace SchoolClasses
{
    using System;

    public class Discipline
    {
        private string name;
        private byte numberOfLectures;
        private byte numberOfExercises;

        public Discipline(string name, byte numberOfLectures, byte numberOfExercises)
        {
            this.Name = name;
            this.NumberOfLectures = numberOfLectures;
            this.NumberOfExercises = numberOfExercises;
        }

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
                    throw new ArgumentNullException("Name can not be blank.");
                }

                this.name = value;
            }
        }

        public byte NumberOfLectures
        {
            get
            {
                return this.numberOfLectures;
            }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Lecturets can not be negative or 0.");
                }

                this.numberOfLectures = value;
            }
        }

        public byte NumberOfExercises
        {
            get
            {
                return this.numberOfExercises;
            }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Exercises can not be negative or 0.");
                }

                this.numberOfExercises = value;
            }
        }

        public override string ToString()
        {
            return string.Format("\"{0}\"\nNumber of lectures: {1}\nNumber of exercises: {2}",
                this.Name, this.NumberOfLectures, this.NumberOfExercises);
        }
    }
}
