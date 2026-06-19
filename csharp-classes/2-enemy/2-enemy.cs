using System;

namespace Enemies
{
    /// <summary>
    /// Defines a zombie enemy.
    /// </summary>
    public class Zombie
    {
        /// <summary>
        /// The health points of the zombie.
        /// </summary>
        public int health;

        /// <summary>
        /// Initializes a new instance of the <see cref="Zombie"/> class
        /// with its health set to 0.
        /// </summary>
        public Zombie()
        {
            health = 0;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Zombie"/> class
        /// with the given health value.
        /// </summary>
        /// <param name="value">
        /// The initial health; must be greater than or equal to 0.
        /// </param>
        /// <exception cref="ArgumentException">
        /// Thrown when <paramref name="value"/> is less than 0.
        /// </exception>
        public Zombie(int value)
        {
            if (value < 0)
            {
                throw new ArgumentException("Health must be greater than or equal to 0");
            }

            health = value;
        }
    }
}
