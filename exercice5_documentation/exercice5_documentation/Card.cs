using System;

namespace exercice5_documentation
{/// <summary>
/// Cette classe permet de créer une carte  pour le jeu Magic The Gathering
/// </summary>
    public class Card
    {
        string name;
        string cost;
        string effect;
        string flavorText;
        /// <summary>
        /// Une carte a les paramètre ci-dessous afin d'être créer
        /// </summary>
        /// <param name="Name"></param>
        /// <param name="Cost"></param>
        /// <param name="Effect"></param>
        /// <param name="FlavorText"></param>
        public Card(string Name, string Cost, string Effect, string FlavorText)
        {
            name = Name;
            cost = Cost;
            effect = Effect;
            flavorText = FlavorText;
        }
        /// <summary>
        /// Function afin de créer une carte
        /// </summary>
        /// <param name="Name"></param>
        /// <param name="Cost"></param>
        /// <param name="Effect"></param>
        /// <param name="FlavorText"></param>
        /// <returns></returns>
        public Card createCard(string Name, string Cost, string Effect, string FlavorText)
        {
            Card card = new Card(Name, Cost, Effect, FlavorText);
            return card;
        }
    }
}
