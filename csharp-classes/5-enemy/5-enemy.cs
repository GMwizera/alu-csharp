using System;

namespace Enemies
{
    /// <summary>
    /// Defines a zombie enemy.
    /// </summary>
    public class Zombie
    {
        // The health points of the zombie.
        private int health;

        // The name of the zombie; defaults to "(No name)".
        private string name = "(No name)";

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

        /// <summary>
        /// Gets or sets the name of the zombie.
        /// </summary>
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        /// <summary>
        /// Gets the current health of the zombie.
        /// </summary>
        /// <returns>The zombie's health value.</returns>
        public int GetHealth()
        {
            return health;
        }

        /// <summary>
        /// Returns a string representation of the zombie's attributes.
        /// </summary>
        /// <returns>
        /// A string in the format
        /// <c>Zombie Name: &lt;name&gt; / Total Health: &lt;health&gt;</c>.
        /// </returns>
        public override string ToString()
        {
            return string.Format("Zombie Name: {0} / Total Health: {1}", name, health);
        }
    }
}
